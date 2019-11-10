//Import de Dependencias
import React, { Component, Fragment } from "react";
import { Link } from "react-router-dom";

//Import de Css
import "../Css/Selector.css";

//Import de configuraciones

//Desarrollo del componente

class Selector extends Component {
  state = {
    Objeto: ""
  //    [
  //     { Id: "1", Nombre: "Mañana" },
  //     { Id: "2", Nombre: "Tarde" },
  //     { Id: "3", Nombre: "Noche" }
  //   ]
  };
componentDidMount(){
  FechTipodata
}

  FechTipodata = async => {
    const Response = this.props.Tipo;
    const data = await Response.json();
    console.log(data, "Lo que trae el llamado234234");
    this.setState({
      Objeto: data
    });
  };


  render() {
    let options = this.props.Tipo;
    // function NumberList(props) {
    //   const numbers = props.Tipo;
    //   const listItems = numbers.map(numbers => <li>{listItems}</li>);
    //   return <ul>{listItems}</ul>;
    // }
    return (
      <Fragment>
        <select className="custom-select custom-select-lg mb-3">
          <option value="" selected disabled hidden>
            {this.props.Titulo}
          </option>
          {/* {NumberList(this.props.Tipo)} */}
          {this.props.Tipo.map((Tipo, i) => {
            <option value={Tipo.Id}>{Tipo.Nombre}</option>;
          })}
        </select>
      </Fragment>
    );
  }
}
export default Selector;
