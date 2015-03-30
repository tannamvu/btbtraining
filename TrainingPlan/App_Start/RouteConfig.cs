using System.Web.Mvc;
using System.Web.Routing;

namespace TrainingPlan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Services",
                url: "Services",
                defaults: new {controller = "Home", action = "Services", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "AboutUs",
                url: "AboutUs",
                defaults: new {controller = "Home", action = "AboutUs", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "ContactUs",
                url: "ContactUs",
                defaults: new {controller = "Home", action = "ContactUs", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
