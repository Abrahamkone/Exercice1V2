
using System.Web.Mvc;
using System.Web.Routing;

public class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        routes.MapRoute(
            name: "Default",
            url: "{Controller}/{action}/{id}",
            defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional }
        );
    }
}