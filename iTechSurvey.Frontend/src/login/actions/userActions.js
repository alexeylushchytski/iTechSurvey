import { userConstants } from "../constants/index";
import axios from "axios";
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
