using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Devpro.Shared.Delegates;
using FluentValidation.WebApi;

namespace NCB.CSI.ApServer {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            FluentValidationModelValidatorProvider.Configure(config);

            config.MessageHandlers.Add(new LogHttpMessagesHandler());
        }
    }
}
