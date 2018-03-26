import { bindActionCreators } from "redux";
import { connect } from "react-redux";
import Header from "../components/header/header.jsx";

function mapStateToProps(state) {
  return {
    state
  };
}

export default connect(mapStateToProps)(Header);
