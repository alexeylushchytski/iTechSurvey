import React from "react";
import { hot } from "react-hot-loader";
import { Route, Switch } from "react-router";
import Routes from "../routes/routes.js";
import Footer from "../layout/components/footer/footer.jsx";
import Header from "../layout/containers/index.js";
import LoginPage from "../login/containers/loginContainer";
import RegisterPage from "../login/components/RegisterPage.jsx";

const RootContainer = () => (
  <div>
    <Header />
    <Switch>
      <Route path={Routes.Login.path} component={LoginPage} />
      <Route path={Routes.SignUp.path} component={RegisterPage}/>
    </Switch>
    <Footer />
  </div>
);

export default hot(module)(RootContainer);
