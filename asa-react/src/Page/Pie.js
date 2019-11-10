//Import de Dependencias
import React from "react";
// import Time from "react-datetime";

//Import de Css
import "../PageCss/Pie.css";
import { isExportDefaultDeclaration } from "@babel/types";

//Import de configuraciones

//Desarrollo del componente
class Pie extends React.Component {
  render() {
    return (
      <React.Fragment>
        <hr />

        <div className="Pie">
          <p>
            &copy; - Programación III TPC - Valenzuela Elias -{"   "}
            {new Date().toLocaleDateString()}
          </p>
        </div>
      </React.Fragment>
    );
  }
}

export default Pie;
