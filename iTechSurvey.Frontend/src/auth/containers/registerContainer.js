import { bindActionCreators } from "redux";
import { connect } from "react-redux";
import { registerUser } from "../actions/userActions";
import RegisterPage from "../components/RegisterPage.jsx";

function mapStateToProps(state) {
  return {
    state
  };
}

function mapDispatchToProps(dispatch) {
  return {
    registerUser: bindActionCreators(registerUser, dispatch)
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(RegisterPage);
