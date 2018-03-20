import React from "react";
import { render } from "react-dom";

export default class Footer extends React.Component {
  constructor(props) {
    super(props);
  }

  render() {
    var year = new Date().getFullYear();
    return (
      <div id="footer" className="footer">
        <p>Copyright © {year} iTechArt</p>
      </div>
    );
  }
}
