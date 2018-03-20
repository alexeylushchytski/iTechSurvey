import { createReducer } from "redux-create-reducer";
import * as actions from "../constants/actionTypes";
const initialState = {};

const User = createReducer(initialState, {
  [actions.LOGINLINK_CLICK](state, action) {
    return state;
  }
});

export default User;
