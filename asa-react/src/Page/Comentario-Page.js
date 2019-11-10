//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/Comentario-Page.css";

//Import de configuraciones

//Desarrollo del componente
class Comentario extends Component {
  render() {
    return (
      <Fragment>
        <div className="Container">
          <div>
            <p>Comision>Alumno>Instancia</p>
          </div>
          <div className="form-group row">
            <div className="col-3"></div>
            <div className=" col-6">
              <label for="comment">Comentario:</label>
              <textarea
                className="form-control HV"
                rows="7"
                id="comment"
              ></textarea>
              <div className="HV">
                <button className="btn btn-info btn-lg btn-block">
                  Enviar Comentario por mail
                </button>
              </div>
            </div>
          </div>
          <div className="row Margen">
            <div className="form-group col-4">
              <label for="comment">Comentario Fecha Alta: </label>
              <textarea
                className="form-control HV"
                rows="5"
                id="comment"
              ></textarea>
              <div className="HV">
                <button className="btn btn-info btn-lg btn-block">
                  Enviar Comentario por mail
                </button>
              </div>
            </div>
            <div className="form-group col-4">
              <label for="comment">Comentario Fecha Alta: </label>
              <textarea
                className="form-control HV"
                rows="5"
                id="comment"
              ></textarea>
              <div className="HV">
                <button className="btn btn-info btn-lg btn-block">
                  Enviar Comentario por mail
                </button>
              </div>
            </div>
            <div className="form-group col-4">
              <label for="comment">Comentario Fecha Alta: </label>
              <textarea
                className="form-control HV"
                rows="5"
                id="comment"
              ></textarea>
              <div className="HV">
                <button className="btn btn-info btn-lg btn-block">
                  Enviar Comentario por mail
                </button>
              </div>
            </div>
          </div>
        </div>
      </Fragment>
    );
  }
}

export default Comentario;
