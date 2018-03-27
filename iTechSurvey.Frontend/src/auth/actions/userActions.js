import { userConstants } from "../constants/index";
import history from "../../helpers/history";
import userService from "../../utils/user.service";

export const login = (email, password) => {
  return dispatch => {
    dispatch(request(email));

    userService.login(email, password).then(
      result => {
        dispatch(success(result));
        history.push("/public");
      },
      error => {
        dispatch(failure(error));
        history.push("/login");
      }
    );

    function request(email) {
      return {
        type: userConstants.LOGIN_REQUEST,
        payload: {
          email
        }
      };
    }

    function success(email) {
      return {
        type: userConstants.LOGIN_SUCCESS,
        payload: {
          email
        }
      };
    }

    function failure(error) {
      return {
        type: userConstants.LOGIN_FAILURE,
        payload: {
          error: error.response.data.error_description
        }
      };
    }
  };
};

export const registerUser = (name, email, password, confirmpassword) => {
  return dispatch => {
    dispatch(registerRequest(name, email, password, confirmpassword));

    userService.registerUser(name, email, password, confirmpassword).then(
      result => {
        dispatch(registerSuccess());
        history.push("/login");
      },
      error => {
        dispatch(registerFailure(error));
      }
    );

    function registerRequest(name, email, password, confirmpassword) {
      return {
        type: userConstants.REGISTER_REQUEST,
        payload: {
          email: email
        }
      };
    }

    function registerSuccess() {
      return {
        type: userConstants.REGISTER_SUCCESS
      };
    }

    function registerFailure(error) {
      return {
        type: userConstants.REGISTER_FAILURE,
        payload: {
          error: error.response.data
        }
      };
    }
  };
};
