using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeesCrudOp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Create",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Edit",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Employees", action = "Edit", id = UrlParameter.Optional }
          );

            routes.MapRoute(
          name: "Delete",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Employees", action = "Delete", id = UrlParameter.Optional }
      );
        }
    }
}
