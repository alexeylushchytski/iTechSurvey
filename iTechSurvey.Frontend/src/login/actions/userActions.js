import { userConstants } from "../constants/index";

export const login = (email, password) => {
  return dispatch => {
    dispatch(request(email, password));
  };

  function request(email, password) {
    return {
      type: userConstants.LOGIN_REQUEST,
      payload: {
        email,
        password
      }
    };
  }
};
