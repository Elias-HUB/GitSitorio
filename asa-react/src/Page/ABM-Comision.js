//Import de Dependencias
import React, { Component, Fragment } from "react";

//Import de Css
import "../PageCss/ABM-Comision.css";

//Import de configuraciones

//Importador de Componentes
import Selector from "../Components/Selector.js";

// import Selector2 from "../Components/Selector copy.js";

//Desarrollo del componente

class Comision extends Component {
  state = {
    Turno: []
  };

  componentDidMount() {
    this.FechTipodata("http://localhost:60907/api/turno");

  }

  FechTipodata = async url => {
    const Response = await fetch(url);
    const data = await Response.json();
    console.log(data, "Lo que trae el llamado desde el back");
    this.setState({
      Turno: data
    });
  };

  render() {
    let listItems = this.state.Turno
    // console.log(listItems, "Lo que trae el dsfsdgdfgfdgdel back");
    return (

      <div>
        {console.log(listItems, "tatata")}
        {console.log(listItems, "tatata2222")}
        <Fragment>
          <select className="custom-select custom-select-lg mb-3">
            <option value="0">abc          </option>
            {this.state.Turno.map((number) => <option value={number.Id}>{number.Nombre} </option>)}
          </select>
        </Fragment>

        <div className="form-group row col-7">
          <label className="col-sm-2 col-form-label">Materia</label>
          <div className="col-sm-10">
            <Selector Titulo={"Tarea 2.0"} Tipo={listItems} />
            {/* <Selector2 Titulo={"Tarea"} Tipo={this.state.data} /> */}
          </div>
        </div>

      </div>
    );
  }
}

export default Comision;
