import { createStore, compose, applyMiddleware, combineReducers } from 'redux';
import $ from 'jquery';
import { composeWithDevTools } from 'redux-devtools-extension';
import createHistory from "history/createBrowserHistory";
import { connectRouter, routerMiddleware } from 'connected-react-router';
//  import thunk from 'redux-thunk'
import reducers from '../layout/reducers/index';

const initialState = {};
const history = createHistory();

const configureStore = (initState) => {
  const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose

  const store = createStore(
    connectRouter(history)(reducers),
    initState,
    compose(window.devToolsExtension ? window.devToolsExtension() : f => f,
      applyMiddleware(
        routerMiddleware(history),
      ), )
  )
  return store
}

const store = configureStore(initialState);

export { store, history };