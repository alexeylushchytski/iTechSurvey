import { createReducer } from "redux-create-reducer";
import { userConstants } from "../constants/index";

const initialState = {};

const User = createReducer(initialState, {
  [userConstants.LOGIN_REQUEST](state, action) {
    const newState = Object.assign({}, state);
    newState.loggingIn = true;
    newState.error = "";
    
    return newState;
  },
  [userConstants.LOGIN_SUCCESS](state, action) {
    const newState = Object.assign({}, state);
    newState.loggingIn = false;
    newState.loggedIn = true;
    newState.email = action.payload.email;
    newState.error = "";

    return newState;
  },
  [userConstants.LOGIN_FAILURE](state, action) {
    const newState = Object.assign({}, state);
    newState.error = action.payload.error;
    newState.loggingIn = false;

    return newState;
  },
  [userConstants.REGISTER_FAILURE](state, action) {
    const newState = Object.assign({}, state);
    newState.error = action.payload.error;

    return newState;
  },
  [userConstants.REGISTER_SUCCESS](state, action) {
    const newState = Object.assign({}, state);
    newState.error ="";

    return newState;
  }
});

export default User;
