import { useAuth } from "../../../context/AuthenticationContext";
import { useNavigate } from "react-router-dom";

export const Profile = () => {
  const auth = useAuth();
  const navigate = useNavigate();

  const handleLogOut = () => {
    auth.logout();
    navigate("/");
  };

  return (
    <div>
      Welcome {auth.user}
      <button onClick={handleLogOut}>Logout</button>
    </div>
  );
};
