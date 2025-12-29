import { Link, useNavigate } from "react-router-dom";
import { useState, useEffect } from "react";
import { useAuth } from "../../../context/authenticationContext";

export const Register = () => {
  const [userData, setUserData] = useState({
    username: "",
    email: "",
    password: "",
    confirmPassword: "",
    name: "",
    surname: "",
    phoneNumber: "",
  });

  const [validationErrors, setValidationErrors] = useState({});
  const { register, loading, error, isAuthenticated } = useAuth();
  const navigate = useNavigate();

  // Redirect if already logged in
  useEffect(() => {
    if (isAuthenticated) {
      navigate("/dashboard");
    }
  }, [isAuthenticated, navigate]);

  // Handle input changes
  const handleChange = (e) => {
    setUserData({
      ...userData,
      [e.target.name]: e.target.value,
    });

    // Clear validation error for this field
    if (validationErrors[e.target.name]) {
      setValidationErrors({
        ...validationErrors,
        [e.target.name]: "",
      });
    }
  };

  // Validate form data
  const validateForm = () => {
    const errors = {};

    if (userData.username.length < 3) {
      errors.username = "Username must be at least 3 characters long.";
    }

    if (userData.password.length < 6) {
      errors.password = "Password must be at least 6 characters long.";
    }

    if (userData.password !== userData.confirmPassword) {
      errors.password = "Password and Confirm Password do not match.";
    }

    setValidationErrors(errors);
    return Object.keys(errors).length === 0;
  };

  // Handle form submission
  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!validateForm()) {
      return;
    }

    const result = await register(userData);

    if (result.success) {
      navigate("/dashboard");
    }
  };

  return (
    <div className="container d-flex justify-content-center align-items-center min-vh-100 bg-primary">
      <div className="form-container p-5 rounded bg-white">
        {error && <div className="alert alert-danger">{error}</div>}
        <form action="">
          <h3 className="text-center">Sign Up</h3>
          <div className="mb-2">
            <label htmlFor="name">Name</label>
            <input
              type="text"
              className="form-control"
              name="name"
              value={userData.name}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Name"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="surname">Surname</label>
            <input
              type="text"
              className="form-control"
              name="surname"
              value={userData.surname}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Surname"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="username">Username</label>
            <input
              type="text"
              className="form-control"
              name="username"
              value={userData.username}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Username"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="email">Email</label>
            <input
              type="email"
              className="form-control"
              name="email"
              value={userData.email}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Email Address"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              className="form-control"
              name="password"
              value={userData.password}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Password"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="confirmPassword">Confirm Password</label>
            <input
              type="password"
              className="form-control"
              name="CconfirmPassword"
              value={userData.confirmPassword}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Confirm Password"
            />
          </div>

          <div className="mb-2">
            <label htmlFor="phoneNumber">Phone Number (optional)</label>
            <input
              type="tel"
              className="form-control"
              name="phoneNumber"
              value={userData.phoneNumber}
              onChange={handleChange}
              disabled={loading}
              placeholder="Enter Phone Number"
            />
          </div>

          <div className="d-grid">
            <button className="btn btn-primary">Sign up</button>
          </div>
          <p className="text-center mt-2">
            Already have an account
            <Link className="ms-2" to="/login">
              Sign in
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
};
