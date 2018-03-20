import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import Header from '../components/header/header.jsx';
import { loginLinkClick } from '../actions/layoutActions';

function mapStateToProps(state) {
    return {
        loginLinkisHide: state.User.loginLinkisHide,
    }
}

function mapDispatchToProps(dispatch) {
    return {
        onLogInClick: bindActionCreators(loginLinkClick, dispatch),
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(Header);