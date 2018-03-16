import React from 'react';
import {render}  from 'react-dom';
import { Provider } from 'react-redux';
import { BrowserRouter } from 'react-router-dom'
import configureStore from './store/init';
import RootContainer from './containers/RootContainer.jsx'
import store from './store/init';

const rootNode = document.getElementById('container');

const renderComponent = (Component) => {
    render(
        <Provider store= {store}>
            <BrowserRouter>
            <Component />
            </BrowserRouter>
        </Provider>, 
        rootNode
    )
};

renderComponent(RootContainer);

if (module.hot) {
    module.hot.accept('./containers/RootContainer.jsx', () => {
      render(require('./containers/RootContainer.jsx'))
    })
}