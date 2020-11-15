using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.AspNetCore.Cors;
using SkateshopApi.App_Start;
using System.Configuration;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SkateshopApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //string origins = ConfigurationManager.AppSettings["Cors-Origins"];
            //config.EnableCors(new EnableCorsAttribute(origins, "*", "*") { SupportsCredentials = true });
            

            var builder = AutofacBuilder.CreateBuilder().AndRegisterComponents().AndGet();
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
