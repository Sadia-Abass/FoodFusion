import { createContext, useState, useContext, useEffect } from "react";
import authenticationService from "../services/authenticationService";

const AuthenticationContext = createContext(null);

export const AuthenticationProvider = ({ children }) => {
  const [user, setUser] = useState(null);
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(true);

  // Authentication provider component
  // Check if user is logged in when app starts
  useEffect(() => {
    const initializeAuthentication = async () => {
      try {
        const token = localStorage.getItem("accessToken");
        if (token) {
          // Try to get current user info
          const userData = await authenticationService.getCurrentUser();
          setUser(userData);
        }
      } catch (error) {
        console.error("Authentication initialization error: ", error);
        // Token might be expired, try to refresh
        try {
          await authenticationService.refreshToken();
          const userData = await authenticationService.getCurrentUser();
          setUser(userData);
        } catch (refreshError) {
          // Refresh failed, clear tokens
          authenticationService.logout();
        }
      } finally {
        setLoading(false);
      }
    };
    initializeAuthentication();
  }, []);

  // Login function
  const login = async (user) => {
    try {
      setError("");
      setLoading(true);

      const response = await authenticationService.login(email, password);
      setUser(response.user);

      return { success: true };
    } catch (error) {
      const errorMessage = error.response?.data?.message || "Login failed";
      setError(errorMessage);
      return { success: false, message: errorMessage };
    } finally {
      setLoading(false);
    }
  };

  // Logout function
  const logout = async () => {
    try {
      await authenticationService.logout();
    } catch (error) {
      console.error("Logout error: ", error);
    } finally {
      setUser(null);
    }
  };

  // Register function
  const register = async (userData) => {
    try {
      setError("");
      setLoading(true);

      const response = await authenticationService.register(userData);
      setUser(response.user);

      return { success: true };
    } catch (error) {
      const errorMessage =
        error.response?.data?.message || "Registration failed";
      setError(errorMessage);
      return { success: false, message: errorMessage };
    } finally {
      setLoading(false);
    }
  };

  // Check if user has specific role
  const hasRole = (role) => {
    return user?.roles?.includes(role) || false;
  };

  const value = {
    user,
    login,
    logout,
    register,
    error,
    loading,
    hasRole,
    isAuthenticated: !!user,
  };

  return (
    <AuthenticationContext.Provider value={value}>
      {children}
    </AuthenticationContext.Provider>
  );
};

export const useAuth = () => {
  const context = useContext(AuthenticationContext);
  if (!context) {
    throw new Error("useAuth must be used within an AuthenticationProvider");
  }
  return context;
};
