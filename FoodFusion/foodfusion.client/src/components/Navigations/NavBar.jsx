import { NavLink } from "react-router-dom";
import { TiThMenuOutline } from "react-icons/ti";
import { IoCloseCircleOutline } from "react-icons/io5";
import "./NavBar.css";

export const NavBar = () => {
  return (
    <div>
      <nav
        className="navbar navbar-expand-lg py-4 py-lg-0 shadow"
        data-bs-theme="light"
      >
        <div className="container-fluid px-4">
          <img
            className=""
            width={150}
            height={150}
            src="./src/assets/logo.png"
            alt="Food fusion logo"
          />
          <button
            className="navbar-toggler border-0"
            type="button"
            data-bs-toggle="offcanvas"
            data-bs-target="#top-navbar"
            aria-controls="top-navbar"
            aria-label="Toggle navigation"
          >
            <span>{<TiThMenuOutline size="2.5rem" color="orange" />}</span>
          </button>
          <div
            className="offcanvas offcanvas-start"
            data-bs-backdrop="static"
            tabindex="-1"
            id="top-navbar"
            aria-labelledby="top-navbarLabel"
          >
            <button
              className="navbar-toggler border-0"
              data-bs-toggle="offcanvas"
              data-bs-target="#top-navbar"
              aria-controls="top-navbar"
            >
              <div className="d-flex justify-content-between p-3">
                <img
                  className="navbar-brand"
                  width={150}
                  height={150}
                  src="./src/assets/logo.png"
                  alt="Food fusion logo"
                />
                <span>
                  <IoCloseCircleOutline size="2.5rem" color="orange" />
                </span>
              </div>
            </button>
            <ul className="navbar-nav ms-lg-auto p-4 p-lg-0 ">
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/">
                  Home
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/delivery">
                  Delivery
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/collection">
                  Collection
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/reservation">
                  Reservation
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/profile">
                  Profile
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/login">
                  Login
                </NavLink>
              </li>
              <li className="nav-item px-3 px-lg-0 py-1 py-lg-4 ">
                <NavLink className="nav-link" to="/register">
                  Register
                </NavLink>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </div>
  );
};
