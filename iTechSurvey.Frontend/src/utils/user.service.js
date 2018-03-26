import axios from "axios";

export function login(email, password) {
  let data =
    "UserName=" + email + "&password=" + password + "&grant_type=password";
  return axios
    .post("http://localhost:54155/api/v2/Login", data, {
      headers: {
        "Content-Type": "application/x-www-form-urlencoded"
      }
    })
    .then(
      function(response) {
        if (response.status === 200) {
          sessionStorage.setItem("token", response.data.access_token);
          return email;
        }
      }
    );
}

export default {
  login
};
