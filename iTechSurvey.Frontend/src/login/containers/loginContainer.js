import { bindActionCreators } from "redux";
import { connect } from "react-redux";
import { login } from "../actions/userActions";
import LoginPage from "../components/loginPage.jsx";

function mapStateToProps(state) {
  return {
      state
  };
}

function mapDispatchToProps(dispatch) {
  return {
    login: bindActionCreators(login, dispatch)
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(LoginPage);
