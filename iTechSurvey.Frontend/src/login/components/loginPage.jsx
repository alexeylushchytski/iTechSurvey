import React from "react";
import { render } from "react-dom";

export default class LoginPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      email: "",
      password: ""
    };

    this.onChange = this.onChange.bind(this);
    this.handleSumbit = this.handleSumbit.bind(this);
  }

  handleSumbit(e) {
    e.preventDefault();
    this.props.login(this.state.email, this.state.password);
  }

  onChange(e) {
    const { name, value } = e.target;
    this.setState({ [name]: value });
  }

  render() {
    const { email, password } = this.state;
    return (
      <div>
        <form
          className="login-form group-form"
          onSubmit={this.handleSumbit}
        >
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
          />
        </form>
      </div>
    );
  }
}
