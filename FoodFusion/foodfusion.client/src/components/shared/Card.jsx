import { Link } from "react-router-dom";
export const Card = ({ cardTitle, cardText, linkClassName, buttonUrl, name, width }) => {
    return (
        <div className="card" style={{ width: "20rem" }}>
            <div className="card-body">
                <h5 className="card-title">{cardTitle}</h5>
                <p className="card-text">{cardText}</p>
                <Link className={linkClassName} to={buttonUrl}>{ name}</Link>
            </div>          
     </div>
  );
}

/*export default Card;*/