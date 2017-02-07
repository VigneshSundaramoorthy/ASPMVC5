using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes(); //Enable attribute based routing
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Greet1",
            //    url: "{controller}/{action}/userName/{userName}/{address}",
            //    defaults: new { controller = "Home", action = "Greet1", id = UrlParameter.Optional, address = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Greet",
                url: "{controller}/{action}/userName/{userName}",
                defaults: new { controller = "Home", action = "Greet", id = UrlParameter.Optional }
            );
            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
