using Microsoft.Web.Http.Routing;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace ResourcesService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.AddApiVersioning();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v{apiVersion}/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { apiVersion = new ApiVersionRouteConstraint() }
            );
        }
    }
}
