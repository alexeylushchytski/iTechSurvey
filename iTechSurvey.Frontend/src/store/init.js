import { createStore, compose, applyMiddleware, combineReducers } from "redux";
import $ from "jquery";
import { composeWithDevTools } from "redux-devtools-extension";
import { connectRouter, routerMiddleware } from "connected-react-router";
import ReduxThunk from "redux-thunk";
import reducers from "../rootreducer/index";
import history from "../helpers/history";

const initialState = {};

const configureStore = initState => {
  const composeEnhancers =
    window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

  const store = createStore(
    connectRouter(history)(reducers),
    initState,
    compose(
      applyMiddleware(ReduxThunk, routerMiddleware(history)),
      window.devToolsExtension ? window.devToolsExtension() : f => f
    )
  );
  return store;
};

const store = configureStore(initialState);

export { store };
