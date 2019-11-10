//Import de Dependencias
import React from "react";
import { Link } from "react-router-dom";

//Import de Css
import "../PageCss/Login-Page.css";

//Import de configuraciones
import Logo from "../Logos/Logo.png";

//Desarrollo del componente
class Login extends React.Component {
  render() {
    return (
      <React.Fragment>
        <div class="wrapper fadeInDown">
          <div id="formContent">
            {/* <!-- Tabs Titles --> */}

            {/* <!-- Icon --> */}
            <div class="fadeIn first">
              <img src={Logo} id="icon" alt="User Icon" />
            </div>

            {/* <!-- Login Form --> */}
            <form>
              <input
                type="text"
                id="login"
                class="fadeIn second"
                name="login"
                placeholder="login"
              />
              <input
                type="text"
                id="password"
                class="fadeIn third"
                name="login"
                placeholder="password"
              />
              <Link to="/Comision">
                <input type="submit" class="fadeIn fourth" value="Log In" />
              </Link>
            </form>

            {/* <!-- Remind Passowrd --> */}
            <div id="formFooter">
              <a class="underlineHover" href="#">
                Forgot Password?
              </a>
            </div>
          </div>
        </div>
      </React.Fragment>
    );
  }
}
export default Login;
