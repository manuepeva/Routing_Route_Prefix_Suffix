﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

          //  config.Routes.MapHttpRoute(
          //      name: "Version1",
          //      routeTemplate: "api/{controller}/{id}",
          //      defaults: new { id = RouteParameter.Optional, controller = "StudentV1" }
          //  );

          //  config.Routes.MapHttpRoute(
          //    name: "Version2",
          //    routeTemplate: "api/{controller}/{id}",
          //    defaults: new { id = RouteParameter.Optional, controller = "StudentV2" }
          //);
        }
    }
}
