import React from "react";
import { render } from "react-dom";

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

export default class RegisterPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      email: "",
      password: "",
      confirmpassword: "",
      name: "",
      formErrors: { email: "", password: "", name: "", confirmpassword: "" },
      registrationError: "",
      emailValid: false,
      passwordValid: false,
      nameValid: false,
      confirmpasswordValid: false,
      formValid: false
    };

    this.onChange = this.onChange.bind(this);
    this.handleSumbit = this.handleSumbit.bind(this);
  }

  validateField(fieldName, value) {
    let fieldValidationErrors = this.state.formErrors;
    let emailValid = this.state.emailValid;
    let passwordValid = this.state.passwordValid;
    let nameValid = this.state.nameValid;
    let confirmpasswordValid = this.state.confirmpasswordValid;

    switch (fieldName) {
      case "email":
        emailValid = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
        fieldValidationErrors.email = emailValid ? "" : " is invalid";
        break;
      case "password":
        passwordValid = value.length >= 6;
        fieldValidationErrors.password = passwordValid ? "" : " is too short";
        break;
      case "name":
        nameValid = value.length >= 2;
        fieldValidationErrors.name = nameValid ? "" : " required";
        break;
      case "confirmpassword":
        confirmpasswordValid =
          this.state.password === this.state.confirmpassword;
        fieldValidationErrors.confirmpassword = confirmpasswordValid
          ? ""
          : " doesnt match password";
        break;
      default:
        break;
    }
    this.setState(
      {
        formErrors: fieldValidationErrors,
        emailValid: emailValid,
        passwordValid: passwordValid,
        nameValid: nameValid,
        confirmpasswordValid: confirmpasswordValid
      },
      this.validateForm
    );
  }

  validateForm() {
    this.setState({
      formValid:
        this.state.emailValid &&
        this.state.passwordValid &&
        this.state.confirmpasswordValid &&
        this.state.nameValid
    });
  }

  componentWillReceiveProps(nextProps) {
    this.setState({
      registrationError: nextProps.state.User.error
    });
  }
  handleSumbit(e) {
    e.preventDefault();
    this.props.registerUser(
      this.state.name,
      this.state.email,
      this.state.password,
      this.state.confirmpassword
    );
  }

  onChange(e) {
    const { name, value } = e.target;
    this.setState({ [name]: value }, () => {
      this.validateField(name, value);
    });
  }

  render() {
    return this.renderRegisterPage();
  }

  renderRegisterPage() {
    const { email, password, name, confirmpassword } = this.state;

    if (!this.props.state.User.loggedIn) {
      return (
        <div className="validation_errors">
          <div className="panel panel-default">
            <FormErrors formErrors={this.state.formErrors} />
            <div className="validation-errors__registration-error panel panel-default">
              {this.state.registrationError}
            </div>
          </div>
          <form
            className="register-form group-form"
            onSubmit={this.handleSumbit}
          >
            <div className="register-form__user-name">
              <label htmlFor="name">Name</label>
              <input
                type="text"
                name="name"
                value={name}
                className="register-form__input-name group-form"
                onChange={this.onChange}
              />
            </div>
            <div className="register-form__user-email">
              <label htmlFor="email">Email</label>
              <input
                type="text"
                name="email"
                value={email}
                className="register-form__input-email group-form"
                onChange={this.onChange}
              />
            </div>
            <div className="register-form__user-password">
              <label htmlFor="password">Password</label>
              <input
                type="password"
                name="password"
                value={password}
                className="register-form__input-password group-form"
                onChange={this.onChange}
              />
            </div>
            <div className="register-form__user-confirmpassword">
              <label htmlFor="confirmpassword">Confirm Password</label>
              <input
                type="password"
                name="confirmpassword"
                value={confirmpassword}
                className="register-form__input-confirmpassword group-form"
                onChange={this.onChange}
              />
            </div>
            <input
              type="submit"
              name="submit"
              value="Create an account"
              className="register-form__input-submit btn btn-primary"
              disabled={!this.state.formValid}
            />
          </form>
        </div>
      );
    } else {
      return (
        <div>
          <strong>You must sign out to create new account.</strong>
        </div>
      );
    }
  }
}
