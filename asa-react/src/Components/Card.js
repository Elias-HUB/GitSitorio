//Import de Dependencias
import React, { Component, Fragment } from "react";
import { Link } from "react-router-dom";

//Import de Css
import "../Css/Card.css";

//Import de configuraciones

//Desarrollo del componente

class Card extends Component {
  render() {
    return (
      <Fragment>
        <div className="card text-white bg-dark">
          <img className="card-img-top" alt="..." src="" />
          <div className="card-body">
            <h5 className="card-title">Titulo</h5>
            <p className="card-text">DESCRIPCION</p>
          </div>
          <Link to="/Alumnos" className="btn btn-secondary btn-lg btn-block">
            <h6>Quiero este</h6>
          </Link>
        </div>
      </Fragment>
    );
  }
}
export default Card;
