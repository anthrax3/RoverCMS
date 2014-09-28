using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Common.Providers.Request
{
    public static class RequestProvider
    {
        #region Public Current Url Methods

        public static string GetCurrentArea()
        {
            return HttpContext.Current == null
                ? string.Empty : HttpContext.Current.Request.RequestContext.RouteData.Values["area"].ToString();
        }

        public static string GetCurrentController()
        {
            return HttpContext.Current == null
                ? string.Empty : HttpContext.Current.Request.RequestContext.RouteData.Values["controller"].ToString();
        }

        public static string GetCurrentAction()
        {
            return HttpContext.Current == null
                ? string.Empty : HttpContext.Current.Request.RequestContext.RouteData.Values["action"].ToString();
        }

        public static string GetCurrentQuery(string query)
        {
            return HttpContext.Current != null
                ? HttpContext.Current.Request.QueryString[query] ?? string.Empty : string.Empty;
        }

        public static bool IsPost()
        {
            if (System.Web.HttpContext.Current != null)
            {
                return System.Web.HttpContext.Current.Request.HttpMethod.Equals("POST");
            }
            return false;
        }

        #endregion

        #region Public Url Referrer Methods

        public static string GetReferrerArea()
        {
            var urlReferrerRouteData = GetReferrerRouteData();

            if (urlReferrerRouteData.Any())
            {
                return urlReferrerRouteData["area"] != null ? urlReferrerRouteData["area"].ToString() : string.Empty;
            }

            return string.Empty;
        }

        public static string GetReferrerController()
        {
            var urlReferrerRouteData = GetReferrerRouteData();

            if (urlReferrerRouteData.Any())
            {
                return urlReferrerRouteData["controller"] != null ? urlReferrerRouteData["controller"].ToString() : string.Empty;
            }

            return string.Empty;
        }

        public static string GetReferrerAction()
        {
            var urlReferrerRouteData = GetReferrerRouteData();

            if (urlReferrerRouteData.Any())
            {
                return urlReferrerRouteData["action"] != null ? urlReferrerRouteData["action"].ToString() : string.Empty;
            }

            return string.Empty;
        }

        #endregion

        #region Private Url Referrer Methods

        private static RouteValueDictionary GetReferrerRouteData()
        {
            // Split the url to url + query string
            if (HttpContext.Current.Request.UrlReferrer != null)
            {
                var fullUrl = HttpContext.Current.Request.UrlReferrer.ToString();
                var questionMarkIndex = fullUrl.IndexOf('?');
                string queryString = null;
                string url = fullUrl;
                if (questionMarkIndex != -1) // There is a QueryString
                {    
                    url = fullUrl.Substring(0, questionMarkIndex); 
                    queryString = fullUrl.Substring(questionMarkIndex + 1);
                }   

                // Arranges
                var request = new HttpRequest(null, url, queryString);
                var response = new HttpResponse(new StringWriter());
                var httpContext = new HttpContext(request, response);

                // Get route data
                var routeData = RouteTable.Routes.GetRouteData(new HttpContextWrapper(httpContext));

                // Return route data
                return routeData != null ? routeData.Values : new RouteValueDictionary();
            }

            // Return new empty dictionary
            return new RouteValueDictionary();
        }
        #endregion
    }
}
