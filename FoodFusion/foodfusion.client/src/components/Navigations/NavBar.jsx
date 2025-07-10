import { NavLink } from "react-router-dom";
import "./NavBar.css";

export const NavBar = () => {
  return (
    <div>
      <nav
        className="navbar navbar-expand-lg py-4 py-lg-0 shadow bg-info"
        data-bs-theme=""
        // style={{background-color: }}
      >
        <div className="container px-4">
          <img src="" alt="" />
          <button
            className="navbar-toggler border-0"
            data-bs-toggle="offcanvas"
            data-bs-target="#top-navbar"
            aria-controls="top-navbar"
          >
            <i className=""></i>
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
                <img src="" alt="" />
                <i className=""></i>
              </div>
            </button>
            <ul className="navbar-nav ms-lg-auto p-4 p-lg-0">
              <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/delivery">
                  Delivery
                </NavLink>
              </li>
              <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/collection">
                  Collection
                </NavLink>
              </li>
              <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/reservation">
                  Reservation
                </NavLink>
              </li>
              <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                <NavLink className="nav-link" to="/login">
                  Login
                </NavLink>
              </li>
              <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
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
