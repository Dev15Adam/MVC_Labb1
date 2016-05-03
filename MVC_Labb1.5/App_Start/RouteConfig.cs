using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Labb1._5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Laser",
                url: "Laser/{action}/{id}",
                defaults: new { controller = "Laser", action = "Eye", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Life",
                url: "Life/{action}/{id}",
                defaults: new { controller = "Life", action = "Live", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
