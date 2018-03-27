using System;
using System.Web.Http;
using DependencyResolution.DependencyResolution;
using iTechart.Survey.DAL;
using iTechart.Survey.DAL.Context;
using iTechArt.Survey.BLL.Services.AuthService;
using iTechArt.Survey.WebApi;
using iTechArt.Survey.WebApi.AuthProvider;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
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
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }


        public void ConfigureOAuth(IAppBuilder app)
        {
            var authService = new AuthService(new SurveyUnitOfWork(new SurveyContext()));
            var OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/v2/Login"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new AuthorizationServerProvider(authService)
            };
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}