import React from "react";
import { hot } from "react-hot-loader";
import { Route, Switch } from "react-router";
import Routes from "../routes/routes.js";
import Footer from "../layout/components/footer/footer.jsx";
import Header from "../layout/components/header/header.jsx";

const RootContainer = () => (
  <div>
    <Header />
    <Switch>
      <Route path={Routes.Login.path} component={Header} />
    </Switch>
    <Footer />
  </div>
);

export default hot(module)(RootContainer);
