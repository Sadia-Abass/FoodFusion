import { NavLink } from "react-router-dom";
// import { FaHome } from "react-icons/fa";
import { MdRestaurantMenu } from "react-icons/md";
import { BiDish } from "react-icons/bi";
import { IoFastFoodOutline } from "react-icons/io5";
import { TfiDashboard } from "react-icons/tfi";
import "./NavBar.css";

export const Sidebar = () => {
  return (
    // <aside className="">
    <div className="container-fluid d-flex vh-100 shadow me-4">
      {/* col-auto col-sm-auto d-flex shadow */}
      <div className="col-6">
        <div className="" data-bs-theme="light">
          <ul className="navbar-nav">
            <li className=" nav-item">
              <NavLink className="nav-link">
                <TfiDashboard size="2em" color="orange" />
                Dashboard
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link">
                <MdRestaurantMenu size="2em" color="orange" />
                Menu Item
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link">
                <BiDish size="2em" color="orange" /> Dish Type
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link">
                <IoFastFoodOutline size="2em" color="orange" />
                Cuisine
              </NavLink>
            </li>
          </ul>
        </div>
      </div>
    </div>
    // </aside>
  );
};
