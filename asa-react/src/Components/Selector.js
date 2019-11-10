//Import de Dependencias
import React, { Component, Fragment } from "react";
import { Link } from "react-router-dom";

//Import de Css
import "../Css/Selector.css";

//Import de configuraciones

//Desarrollo del componente
class Selector extends Component {
  state = {
    Objeto: [this.props.Tipo]
    // Objeto: [
    //   { Id: "1", Nombre: "Mañana" },
    //   { Id: "2", Nombre: "Tarde" },
    //   { Id: "3", Nombre: "Noche" }
    // ]
  };
  // constructor(props) {
  //   super(props);
  //   this.state = {
  //     Objeto: this.props.Tipo
  //   };
  // }
  render() {
    { console.log(this.props.Tipo, "ACA ES EL SELECTOR antes del return") }
    return (
      <Fragment>
        <select className="custom-select custom-select-lg mb-3">
          <option value="">            {this.props.Titulo}          </option>
          {console.log(this.props.Tipo, "ACA ES EL SELECTOR")}
          {this.props.Tipo.map((number) => <option value={number.Id}>{number.Nombre} </option>)}
        </select>
      </Fragment>
    );
  }
}
export default Selector;