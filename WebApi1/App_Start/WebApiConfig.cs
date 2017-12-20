using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Version1",
                routeTemplate: "api/v1/students/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "StudentsV1" }
            );
        }
    }
}
