using System.ComponentModel;
using System.Threading.Tasks;
using System.Web.Http;
using DependencyResolution.DependencyResolution;
using iTechArt.Survey.WebApi;
using Microsoft.Owin;
using Owin;
using StructureMap;

[assembly: OwinStartup(typeof(Startup))]
namespace iTechArt.Survey.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = IoC.Initialize();
            HttpConfiguration config = new HttpConfiguration();
            config.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}