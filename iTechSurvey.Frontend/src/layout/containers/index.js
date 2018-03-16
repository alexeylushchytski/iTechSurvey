import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import Header from '../components/header/header.jsx';
import { userLogIn } from '../actions/layoutActions.js';

function mapStateToProps(state) {
    return {
        loginLinkisHide: state.User.loginLinkisHide,
    }
}

function mapDispatchToProps(dispatch) {
    return {
        userLogIn: bindActionCreators(userLogIn, dispatch),
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(Header);