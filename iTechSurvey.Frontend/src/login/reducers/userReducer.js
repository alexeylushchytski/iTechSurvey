import { createReducer } from "redux-create-reducer";
import { userConstants } from "../constants/index";

const initialState = {};

const User = createReducer(initialState, {
  [userConstants.LOGIN_REQUEST](state, action) {
    const newState = Object.assign({}, state);
    newState.loggingIn = true;
    return newState;
  },
  [userConstants.LOGIN_SUCCESS](state, action) {
    const newState = Object.assign({}, state);
    newState.loggingIn = false;
    newState.loggedIn = true;
    newState.email = action.payload.email;
    return newState;
  }
});

export default User;
