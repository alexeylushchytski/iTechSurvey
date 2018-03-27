import { createStore, compose, applyMiddleware, combineReducers } from "redux";
import $ from "jquery";
import { composeWithDevTools } from "redux-devtools-extension";
import { connectRouter, routerMiddleware } from "connected-react-router";
import ReduxThunk from "redux-thunk";
import { persistStore, persistReducer } from "redux-persist";
import storage from "redux-persist/lib/storage";
import reducers from "../rootreducer/index";
import history from "../helpers/history";

const initialState = {};

const persistConfig = {
  key: "root",
  storage
};

const persistedReducer = persistReducer(persistConfig, reducers);

const configureStore = initState => {
  const composeEnhancers =
    window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

  const store = createStore(
    connectRouter(history)(persistedReducer),
    initState,
    compose(
      applyMiddleware(ReduxThunk, routerMiddleware(history)),
      window.devToolsExtension ? window.devToolsExtension() : f => f
    )
  );
  return store;
};

const store = configureStore(initialState);
let persistor = persistStore(store);
export { store, persistor };
