import React from "react";
import { render } from "react-dom";
import { Link } from "react-router-dom";
import Routes from "../../../routes/routes";
import { envelope } from "../../../../images/envelope.png";

const About = () => {
  return (
    <a className="header__about-link" href="https://www.itechart.by/about">
      Company
    </a>
  );
};

const EnvelopePicture = () => {
  return (
    <img className="header__envelope-picture" src="/images/envelope.png" />
  );
};

export default class Header extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      UserName: this.props.state.User.email,
    };
  }

  componentWillReceiveProps(nextProps) {
    if (nextProps.state.User.email !== undefined) {
      this.setState({
        UserName: nextProps.state.User.email,
      });
    }
  }

  renderHeader() {
    let loginLinkAvailable = this.state.UserName == undefined
    if (loginLinkAvailable) {
      return (
        <div id="header" className="header">
          <EnvelopePicture />
          <Link to={Routes.Login.path} className="header__login-link">
            Login
          </Link>
          <strong className="header__userName">{this.state.UserName}</strong>
          <About />
        </div>
      );
    } else
      return (
        <div id="header" className="header">
          <EnvelopePicture />
          <strong className="header__userName">{this.state.UserName}</strong>
          <About />
        </div>
      );
  }

  render() {
    return this.renderHeader();
  }
}
