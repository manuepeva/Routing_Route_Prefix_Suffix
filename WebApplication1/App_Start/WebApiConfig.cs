using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebApplication1.Custom;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ManuelRoute",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IHttpControllerSelector),
                new CustomControllerSelector(config));

            //    config.Routes.MapHttpRoute(
            //    name: "Version2",
            //    routeTemplate: "api/v2/students/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "StudentsV2" }
            //);
        }
    }
}
