using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults這行代表當URL沒有帶任何路段，例如https://localhost:44325 一樣會導引道https://localhost:44325/Home/Index
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
