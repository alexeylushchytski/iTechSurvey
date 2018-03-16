import { createReducer } from 'redux-create-reducer';
import * as actions from '../../constants/global';
const initialState = {
  loginLinkisHide: false,
};
 
const User = createReducer(initialState, {
  [actions.USER_LOGIN](state, action) {
    const newState = Object.assign({}, state);
    newState.loginLinkisHide = !newState.loginLinkisHide;
    return newState;
    }
});

export default User;