using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NHCCServiceTracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Cuisine/french  - parameter, not an action, but want it passed in.  So define a new route
            // order of routes is significant  -- first one found wins

            routes.MapRoute("Cuisine",
                "cuisine/{name}",
                new {controller = "Cuisine", action = "Search", name = UrlParameter.Optional });  // default route for the maproute

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
