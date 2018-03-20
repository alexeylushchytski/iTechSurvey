import React, { Component } from "react";
import { Route } from 'react-router';
import { hot } from 'react-hot-loader';
import Footer from '../layout/components/footer/footer.jsx';
import HeaderContainer from '../layout/containers/index';

const Routes = (
    <div>
        <Route path="/login" component={HeaderContainer} />
    </div>
);

export default Routes;