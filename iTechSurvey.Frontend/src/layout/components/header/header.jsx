import React from 'react';
import { render } from 'react-dom';
import { Link } from "react-router-dom";
import { envelope } from '../../../../images/envelope.png';

const About = () => {
  return (
    <div>
      <a id="react-a-about-link" href="https://www.itechart.by/about">Company</a>
    </div>
  )
}


const EnvelopePicture = () => {
  return (
    <img id="react-img-envelope" src="/images/envelope.png" />
  )
}


const LoginLink = (onClick) => {
  return (
    <Link to="/login" id="react-a-login-link" onClick={() => { onClick() }}>Login</Link>
  )
}


export default class Header extends React.Component {
  constructor(props) {
    super(props);
  }
  componentDidMount() {

  };

  isAvailable() {
    const loginLink = LoginLink(this.props.userLogIn);
    if (!this.props.loginLinkisHide) {
      return (
        <div id="header">
          <EnvelopePicture />
          {loginLink}
          <About />
        </div>
      )
    }
    else return (
      <div id="header">
        <EnvelopePicture />
        <About />
      </div>
    )
  }

  render() {
    return this.isAvailable();
  }
}