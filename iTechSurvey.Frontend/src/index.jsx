import React from "react";
import { render } from "react-dom";
import { Provider } from "react-redux";
import { Router } from "react-router-dom";
import { ConnectedRouter } from "connected-react-router";
import { PersistGate } from "redux-persist/integration/react";
import configureStore from "./store/init";
import RootContainer from "./containers/RootContainer.jsx";
import { store, persistor } from "./store/init";
import history from "./helpers/history";

const rootNode = document.getElementById("container");

render(
  <Provider store={store}>
    <PersistGate loading={null} persistor={persistor}>
      <ConnectedRouter history={history}>
        <RootContainer />
      </ConnectedRouter>
    </PersistGate>
  </Provider>,
  rootNode
);

if (module.hot) {
  module.hot.accept("./containers/RootContainer.jsx", () => {
    render(require("./containers/RootContainer.jsx"));
  });
}
