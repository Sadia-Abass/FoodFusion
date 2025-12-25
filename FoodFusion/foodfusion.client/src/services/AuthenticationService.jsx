import axios from "axios";

const API_BASE_URL = "https://localhost:7234/api";

// Base URL of your ASP.NET Core API
const api = axios.create({
  baseURL: API_BASE_URL,
  header: {
    "Content-Type": "application/json",
  },
});

// Axios interceptor to automatically add authorization header
api.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("accessToken");
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

// Axios interceptor to handle token refresh
api.interceptors.response.use(
  (response) => response,
  async (error) => {
    // Try to refresh the token
    const originalRequest = error.config;

    // If we get 401 (Unauthorized) and haven't already tried to refresh
    if (error.response?.status == 401 && !originalRequest._retry) {
      originalRequest._retry = true;

      try {
        await authService.refreshToken();

        // Retry the original request with new token
        const token = localStorage.getItem("accessToken");
        originalRequest.headers.Authorization = `Bearer ${token}`;
        return api(originalRequest);
      } catch (refreshError) {
        // Refresh failed, redirect to login
        authService.logout();
        window.location.href = "/login";
        return Promise.reject(refreshError);
      }
    }
    return Promise.reject(error);
  }
);

const authService = {
  // Register new user
  async register(userData) {
    const response = await api.post("/auth/register", userData);

    // Store tokens in localStorage
    localStorage.setItem("accessToken", response.data.accessToken);
    localStorage.setItem("refreshToken", response.data.refreshToken);

    return response.data;
  },

  // Login user
  async login(email, password) {
    const response = await api.post("/auth/login", { email, password });

    // Store tokens in localStorage
    localStorage.setItem("accessToken", response.data.accessToken);
    localStorage.setItem("refreshToken", response.data.refreshToken);

    return response.data;
  },

  // Logout user
  async logout() {
    try {
      // Call logout endpoint to revoke refresh token
      await api.post("/auth/logout");
    } catch (error) {
      console.error("Logout error: ", error);
    } finally {
      // Clear tokens from localStorage
      localStorage.removeItem("accessToken");
      localStorage.removeItem("refreshToken");
    }
  },

  // Refresh access token
  async refreshToken() {
    const refreshToken = localStorage.getItem("refreshToken");
    const accessToken = localStorage.getItem("accessToken");

    if (!refreshToken || !accessToken) {
      throw new Error("No refresh token available");
    }

    const response = await api.post("/auth/refresh", {
      accessToken,
      refreshToken,
    });

    // Store new tokens
    localStorage.setItem("accessToken", response.data.accessToken);
    localStorage.setItem("refreshToken", response.data.refreshToken);
  },

  // Get current user information
  async getCurrentUser() {
    const response = await api.get("/auth/me");
    return response.data;
  },

  // check if user is logged in
  isAuthenticated() {
    return !!localStorage.getItem("accessToken");
  },
};

export default authService;
