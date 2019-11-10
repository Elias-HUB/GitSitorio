//Import de Dependencias
import React from "react";

//Import de Css
import "../PageCss/Cabecera.css";
//Import de configuraciones
import Logo from "../Logos/UtnCabecera.jpg";

//Desarrollo del componente
class Cabecera extends React.Component {
  render() {
    return (
      <React.Fragment>
        <form>
          <div className="p-3 text-white Cabecera">
            <div className="row">
              <div>
                <img src={Logo} alt="" />
              </div>
              <div className="">
                <h1>Cabecera React</h1>
              </div>
            </div>
          </div>
          <hr />
        </form>
      </React.Fragment>
    );
  }
}

export default Cabecera;
