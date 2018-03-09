using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Routing;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Routing;

namespace iTechArt.Survey.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
             config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap =
                {
                    ["apiVersion"] = typeof( ApiVersionRouteConstraint )
                }
            };
            config.MapHttpAttributeRoutes(constraintResolver);
            config.AddApiVersioning(o => o.ReportApiVersions = true);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v{version:apiVersion}/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
