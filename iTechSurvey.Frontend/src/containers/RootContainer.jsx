import React, { Component } from "react";
import { Route } from 'react-router-dom'
import { hot } from 'react-hot-loader';
import Footer from '../layout/components/footer/footer.jsx';
import HeaderContainer from '../layout/containers/index';

const RootContainer = () => (
    <div>
        <Route exact path="/public" component={HeaderContainer} />
        <Route exact path="/public" component={Footer} />
        <Route exact path="/login" component={HeaderContainer} />
        <Route path="/login" component={Footer} />
    </div>
);

export default hot(module)(RootContainer);