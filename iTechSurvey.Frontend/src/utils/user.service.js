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
    .then(function(response) {
      if (response.status === 200) {
        sessionStorage.setItem("token", response.data.access_token);
        return email;
      }
    });
}

export function registerUser(name, email, password, confirmpassword) {
  return axios
    .post(
      "http://localhost:54155/api/v2/Auth/Signup",
      {
        Name: name,
        Email: email,
        Password: password,
        VerificationPassword: confirmpassword
      },
      {
        headers: {
          "Content-Type": "application/json"
        }
      }
    )
    .then(response => {
      if (response.status === 200) {
        return email;
      }
    });
}

export default {
  login,
  registerUser
};
