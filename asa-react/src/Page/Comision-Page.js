//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/Comision-Page.css";

//Import de Componente
import Card from "../Components/Card.js";

//Import de configuraciones

//Desarrollo del componente

class Comision extends Component {
  render() {
    return (
      <Fragment>
        <div className="col-md-6 row">
          <h3>Comiciones</h3>
          <button type="button" className="btn mt-50 btn-lg btn-primary">
            Agregar Comisión
          </button>
        </div>
        <div className="card-columns Margen">
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
          <Card />
        </div>
      </Fragment>
    );
  }
}

export default Comision;
