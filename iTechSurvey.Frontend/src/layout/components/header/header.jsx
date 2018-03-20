import React from 'react';
import { render } from 'react-dom';
import { Link } from "react-router-dom";
import { envelope } from '../../../../images/envelope.png';

const About = () => {
  return (
    <a className="header__about-link" href="https://www.itechart.by/about">Company</a>
  )
}


const EnvelopePicture = () => {
  return (
    <img className="header__envelope-picture" src="/images/envelope.png" />
  )
}


const LoginLink = ({ onClick }) => {
  return (
    <Link to="/login" className="header__login-link" onClick={onClick}>Login</Link>
  )
}


export default class Header extends React.Component {
  constructor(props) {
    super(props);
    this.state = { loginLinkAvailable: true };
  }

  isAvailable() {
    if (this.state.loginLinkAvailable) {
      return (
        <div id="header" className="header">
          <EnvelopePicture />
          <LoginLink onClick={() => { this.setState({ loginLinkAvailable: false }) }} />
          <About />
        </div>
      )
    }
    else return (
      <div id="header" className="header">
        <EnvelopePicture />
        <About />
      </div>
    )
  }

  render() {
    return this.isAvailable();
  }
}