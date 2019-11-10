//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/List-Alumnos-Page.css";

//Import de configuraciones

//Desarrollo del componente
class ListAlumnos extends Component {
  render() {
    return (
      <Fragment>
        <div>
          <div className="container  row">
            <div className="col-4">
              <p>COMICION</p>
            </div>
            <div className="col-4">
              <button type="button" class="btn btn-info">
                Agregar Alumno
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
                  <th scope="col">Legajo</th>
                  <th scope="col">Nombre</th>
                  <th scope="col">Apellido</th>
                  <th scope="col">Handle</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope="row">1</th>
                  <td>Mark</td>
                  <td>Otto</td>
                  <td>@mdo</td>
                </tr>
                <tr>
                  <th scope="row">2</th>
                  <td>Jacob</td>
                  <td>Thornton</td>
                  <td>@fat</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </Fragment>
    );
  }
}

export default ListAlumnos;
