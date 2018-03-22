import { userConstants } from "../constants/index";
import axios from "axios";
import history from "../../helpers/history";

export const login = (email, password) => {
  return dispatch => {
    dispatch(request(email, password));
  };

  function request(email, password) {
    axios
      .post("http://localhost:54155/api/v2/Auth/Login", {
        Name: email,
        Email: email,
        Password: password
      })
      .then(function(response) {
        console.log(response);
      })
      .catch(function(error) {
        console.log(error);
      });

    return {
      type: userConstants.LOGIN_REQUEST,
      payload: {
        email,
        password
      }
    };
  }
};
