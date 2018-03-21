import { createReducer } from "redux-create-reducer";
import { userConstants } from "../constants/index";

const initialState = {};

const User = createReducer(initialState, {
  [userConstants.LOGIN_REQUEST](state, action) {
    const newState = Object.assign({}, state);
    newState.loggingIn = true;
    newState.email = action.payload.email;
    newState.password = action.payload.password;
    return newState;
  }
});

export default User;
