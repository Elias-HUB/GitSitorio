//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/List-Instancia-Page.css";

//Import de configuraciones

//Desarrollo del componente
class ListInstancia extends Component {
  render() {
    return (
      <Fragment>
        <div>
          <div className="container  row">
            <div className="col-4">
              <p>COMICION > ALUMNO </p>
            </div>
            <div className="col-4">
              <button type="button" class="btn btn-info">
                Agregar
              </button>
            </div>
            <div className="col-4">
              <button type="button" class="btn btn-info">
                Info
              </button>
            </div>
          </div>
          <div className="container">
            <table className="table table-hover">
              <thead>
                <tr>
                  <th scope="col">Nombre</th>
                  <th scope="col">Tipo</th>
                  <th scope="col">Fecha Inicio</th>
                  <th scope="col">Fecha Fin</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope="row">TP1</th>
                  <td>Trabajo Practico</td>
                  <td>15/09</td>
                  <td>29/09</td>
                </tr>
                <tr>
                  <th scope="row">TPC</th>
                  <td>Trabajo Practico</td>
                  <td>01/10</td>
                  <td>30/11</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </Fragment>
    );
  }
}

export default ListInstancia;
