//Import de Dependencias
import React, { Component } from "react";
import { BrowserRouter, Router, Switch } from "react-router-dom";
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

//Import de Css

// Desarrollo del componente
class Master extends Component {
  render() {
    return (
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
    );
  }
}

export default Master;
