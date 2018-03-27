import React from "react";
import { render } from "react-dom";
import Routes from "../../routes/routes";
import {Link} from "react-router-dom";

const FormErrors = ({ formErrors }) => (
  <div className="formErrors">
    {Object.keys(formErrors).map((fieldName, i) => {
      if (formErrors[fieldName].length > 0) {
        return (
          <p key={i}>
            {fieldName} {formErrors[fieldName]}
          </p>
        );
      } else {
        return "";
      }
    })}
  </div>
);

export default class LoginPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      email: "",
      password: "",
      formErrors: { email: "", password: "" },
      loginError: "",
      emailValid: false,
      passwordValid: false,
      formValid: false
    };

    this.onChange = this.onChange.bind(this);
    this.handleSumbit = this.handleSumbit.bind(this);
  }

  componentWillReceiveProps(nextProps) {
    if (nextProps.state.User.error !== undefined) {
      this.setState({
        loginError: nextProps.state.User.error
      });
    }
  }

  validateField(fieldName, value) {
    let fieldValidationErrors = this.state.formErrors;
    let emailValid = this.state.emailValid;
    let passwordValid = this.state.passwordValid;

    switch (fieldName) {
      case "email":
        emailValid = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
        fieldValidationErrors.email = emailValid ? "" : " is invalid";
        break;
      case "password":
        passwordValid = value.length >= 6;
        fieldValidationErrors.password = passwordValid ? "" : " is too short";
        break;
      default:
        break;
    }
    this.setState(
      {
        formErrors: fieldValidationErrors,
        emailValid: emailValid,
        passwordValid: passwordValid
      },
      this.validateForm
    );
  }

  validateForm() {
    this.setState({
      formValid: this.state.emailValid && this.state.passwordValid
    });
  }

  handleSumbit(e) {
    e.preventDefault();
    this.props.login(this.state.email, this.state.password);
  }

  onChange(e) {
    const { name, value } = e.target;
    this.setState({ [name]: value }, () => {
      this.validateField(name, value);
    });
  }

  render() {
    const { email, password } = this.state;
    return (
      <div>
        <div className="panel panel-default">
          <FormErrors formErrors={this.state.formErrors} />
        </div>
        <form className="login-form group-form" onSubmit={this.handleSumbit}>
          <div className="login-form__validation-errors">
            <div>
              <strong>{this.state.loginError}</strong>
            </div>
          </div>
          <div className="login-form__user-email">
            <label htmlFor="email">Email</label>
            <input
              type="text"
              name="email"
              value={email}
              className="login-form__input-email group-form"
              onChange={this.onChange}
            />
          </div>
          <div className="login-form__user-password">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              name="password"
              value={password}
              className="login-form__input-password group-form"
              onChange={this.onChange}
            />
          </div>
          <input
            type="submit"
            name="submit"
            value="Login"
            className="login-form__input-submit btn btn-primary"
            disabled={!this.state.formValid}
          />
        </form>
        <Link to={Routes.SignUp.path}>Create new account</Link>
      </div>
    );
  }
}
