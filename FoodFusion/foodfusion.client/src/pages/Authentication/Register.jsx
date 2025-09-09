import { Link } from "react-router-dom";

export const Register = () => {
  return (
    <div className="login template d-flex justify-content-center align-items-center vh-100 bg-primary">
      <div className="form-container p-5 rounded bg-white">
        <form action="">
          <h3 className="text-center">Sign Up</h3>
          <div className="mb-2">
            <label htmlFor="name">Name</label>
            <input
              type="text"
              className="form-control"
              name="name"
              placeholder="Enter Name"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="suname">Surname</label>
            <input
              type="text"
              className="form-control"
              name="surname"
              placeholder="Enter Surname"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="email">Email</label>
            <input
              type="email"
              className="form-control"
              name="email"
              placeholder="Enter Email Address"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              className="form-control"
              name="password"
              placeholder="Enter Password"
            />
          </div>
          <div className="mb-2">
            <label htmlFor="password">Confirm Password</label>
            <input
              type="password"
              className="form-control"
              name="password"
              placeholder="Enter Confirm Password"
            />
          </div>
          <div className="d-grid">
            <button className="btn btn-primary">Sign in</button>
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
