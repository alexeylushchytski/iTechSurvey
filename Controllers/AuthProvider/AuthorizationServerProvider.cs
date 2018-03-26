using System.Security.Claims;
using System.Threading.Tasks;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.BLL.Services.AuthService;
using Microsoft.Owin.Security.OAuth;

namespace iTechArt.Survey.WebApi.AuthProvider
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly IAuthService _authService;


        public AuthorizationServerProvider(IAuthService authService)
        {
            _authService = authService;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            if (await _authService.ValidateUser(context.UserName, context.Password))
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", "user"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
            }
        }
    }
}