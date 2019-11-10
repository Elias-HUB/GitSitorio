//Import de Dependencias
import React, { Component } from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";

//Import Boostrap
import "bootstrap/dist/css/bootstrap.css";

//Import de Componente

//Import de Page
import Cabecera from "./Page/Cabecera.js";
import Pie from "./Page/Pie.js";
import Cuerpo from "./Page/Cuerpo.js";
import Login from "./Page/Login-Page.js";
import Comision from "./Page/Comision-Page.js";
import ListAlumnos from "./Page/List-Alumnos-Page.js";
import ListInstancia from "./Page/List-Instancia-Page.js";
import Comentario from "./Page/Comentario-Page.js";
import AbmAlumno from "./Page/ABM-Alumno.js";
import AbmComision from "./Page/ABM-Comision.js";
// import MASTER from "./Page/Master-Page.js";

//Import de Css
import "./App.css";

// Desarrollo del componente
class App extends Component {
  render() {
    return (
      <React.Fragment>
        <Cabecera></Cabecera>
        <BrowserRouter>
          <Switch>
            <Route exact path="/Login" component={Login} />
            <Route exact path="/Comision" component={Comision} />
            <Route exact path="/Alumnos" component={ListAlumnos} />
            <Route path="/Instancia" component={ListInstancia} />
            <Route path="/Comentario" component={Comentario} />
            <Route path="/AltaAlumno" component={AbmAlumno} />
            <Route path="/AltaComision" component={AbmComision} />
          </Switch>
        </BrowserRouter>
        <Pie></Pie>
      </React.Fragment>
    );
  }
}

export default App;
