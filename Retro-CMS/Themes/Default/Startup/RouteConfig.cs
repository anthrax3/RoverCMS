using System.Web.Mvc;
using System.Web.Routing;

namespace Default.Startup
{
    public class RouteConfig
    {
        public RouteConfig()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // BotDetect requests must not be routed
            RouteTable.Routes.IgnoreRoute("{*botdetect}",
              new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            RouteTable.Routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
