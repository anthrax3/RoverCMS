using System.Web.Optimization;

namespace Default.Startup
{
    public class BundleConfig
    {
        public BundleConfig()
        {
            var bundleCollection = new BundleCollection
            {
                new StyleBundle("~/Themes/Default/Content/Stylesheets")
                    .Include("~/Themes/Default/Content/Stylesheets/bootstrap-water-min.css")
                    .Include("~/Themes/Default/Content/Stylesheets/Common.css"),
                new ScriptBundle("~/Themes/Default/Content/Javascripts")
                    .Include("~/Themes/Default/Content/Javascripts/jquery-1.7.1.min.js")
                    .Include("~/Themes/Default/Content/Javascripts/bootstrap.min.js")
            };

            foreach (var bundle in bundleCollection)
            {
                BundleTable.Bundles.Add(bundle);
            }
        }
    }
}
