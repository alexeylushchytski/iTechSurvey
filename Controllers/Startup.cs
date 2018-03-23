using System;
using System.Web.Http;
using DependencyResolution.DependencyResolution;
using iTechArt.Survey.WebApi;
using iTechArt.Survey.WebApi.AuthProvider;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace iTechArt.Survey.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = IoC.Initialize();
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            config.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }


        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/Login0"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new AuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}