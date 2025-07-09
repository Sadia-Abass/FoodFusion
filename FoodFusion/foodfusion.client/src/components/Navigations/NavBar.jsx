import { NavLink } from "react-router-dom";

export const NavBar = () => {
  return (
    <div>
      <header>
        <nav
          className="navbar navbar-expand-lg py-4 py-lg-0 shadow"
          data-bs-theme="dark"
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
                  <NavLink className="nav-link" to="/">
                    Delivery
                  </NavLink>
                </li>
                <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                  <NavLink className="nav-link" to="/">
                    Collection
                  </NavLink>
                </li>
                <li className="nav-link px-3 px-lg-0 py-1 py-lg-4">
                  <NavLink className="nav-link" to="/">
                    Book Table
                  </NavLink>
                </li>
              </ul>
            </div>
          </div>
        </nav>
      </header>
    </div>
  );
};
