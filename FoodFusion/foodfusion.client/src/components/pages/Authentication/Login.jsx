import { Link, useNavigate, useLocation } from "react-router-dom";
import "./login.css";
import { useState } from "react";

export const Login = () => {
  const [user, setUser] = useState("");
  const auth = useAuth();
  const navigation = useNavigate();
  const location = useLocation();

  const redirecrPath = location.state?.path || "/";

  const handleLogin = (e) => {
    e.preventDefault();
    auth.login(user);
    navigation(redirecrPath, { replace: true });
    console.log("Logging in user: ", user);
  };
  return (
    <div className="login template d-flex justify-content-center align-items-center vh-100 bg-primary">
      <div className="form-container p-5 rounded bg-white">
        <form action="">
          <h3 className="text-center">Sign In</h3>
          <div className="mb-2">
            <label htmlFor="email">Email</label>
            <input
              type="email"
              className="form-control"
              name="email"
              placeholder="Enter Email Address"
              onClick={(e) => setUser(e.target.value)}
            />
          </div>
          <div className="mb-2">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              className="form-control"
              name="password"
              placeholder="Enter Password"
              onClick={(e) => setUser(e.target.value)}
            />
          </div>
          <div className="mb-2">
            <input
              type="checkbox"
              className="custom-control custom-checkbox"
              id="check"
            />
            <label htmlFor="check" className="custom-label-label ms-2">
              Remember me
            </label>
          </div>
          <div className="d-grid">
            <button className="btn btn-primary" onClick={handleLogin}>
              Sign in
            </button>
          </div>
          <p className="text-center mt-2">
            Forgot <Link to=""> Password?</Link>
            Not a member
            <Link className="ms-2" to="/register">
              Sign up
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
};
