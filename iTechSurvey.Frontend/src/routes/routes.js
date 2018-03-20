import React, { Component } from "react";
import { Route } from "react-router";
import { hot } from "react-hot-loader";
import Footer from "../layout/components/footer/footer.jsx";
import HeaderContainer from "../layout/containers/index";

const Routes = {
  Login: {
    path: "/login",
    title: "Login"
  },
  Home: {
    path: "/public",
    title: "Home"
  }
};

export default Routes;
