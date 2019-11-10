//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/ABM-Alumno.css";

//Import de configuraciones

//Desarrollo del componente

class Alumno extends Component {
  render() {
    return (
      <Fragment>
        <div className="container">
          <div className="form-row">
            <div className="form-group col-md-4">
              <h4>Ingresá los datos del Alumno</h4>
            </div>
          </div>

          {/* 1ª Fila */}
          <div className="form-row">
            <div className="form-group col-md-3">
              <label htmlFor="">Legajo</label>
              <input
                type="text"
                className="form-control"
                placeholder="38359359"
              />
            </div>

            <div className="form-group col-md-3">
              <button className="btn btn-dark">Buscar</button>
            </div>
          </div>

          {/* 2º Fila */}
          <div className="form-row">
            <div className="form-group col-md-3">
              <label htmlFor="">Nombre</label>

              <input
                type="text"
                className="form-control"
                placeholder="Agustin"
              />
            </div>
            <div className="form-group col-md-4">
              <label htmlFor="">Apellido</label>

              <input
                type="text"
                className="form-control"
                placeholder="Argento"
              />
            </div>
          </div>

          {/* 3º Fila */}
          <div className="form-row">
            <div className="form-group col-md-4">
              <label htmlFor="">Celular</label>
              <input
                type="text"
                className="form-control"
                placeholder="11470654"
              />
            </div>

            <div className="form-group col-md-7">
              <label htmlFor="">Email</label>
              <div className="input-group">
                <div className="input-group-prepend">
                  {/* <div className="input-group-text form-control " type="text">@</div> */}
                </div>
                <input
                  className="form-control"
                  type="text"
                  //   type="email"
                  //   name="email"
                  placeholder="name@example.com"
                />
              </div>
            </div>
          </div>
          <div>
            {/* 4º Fila */}
            <div className="form-row">
              <div className="form-group col-md-5">
                <label htmlFor="">Dirección</label>
                <input
                  type="text"
                  className="form-control"
                  placeholder="Avenida Siempreviva 742"
                />
              </div>

              <div className="form-group col-md-4">
                <label htmlFor="">Ciudad</label>
                <input
                  type="text"
                  className="form-control"
                  placeholder="Pacheco"
                />
              </div>

              <div className="form-group col-md-2">
                <label htmlFor="">CP</label>
                <input
                  type="text"
                  className="form-control"
                  placeholder="1784"
                />
              </div>
            </div>
          </div>

          <div>
            <button className="btn btn-dark">Guardar</button>
          </div>
        </div>
      </Fragment>
    );
  }
}

export default Alumno;
