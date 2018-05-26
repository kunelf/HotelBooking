using System.Web;
using System.Web.Optimization;

namespace WebSiteHotel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/layout").Include(
                                 "~/Content/css/animate.css",
                                 "~/Content/css/bootstrap.css",
                                 "~/Content/css/magnific-popup.css",
                                 "~/Content/css/flexslider.css",
                                 "~/Content/css/owl.carousel.min.css",
                                 "~/Content/css/owl.theme.default.min.css",
                                 "~/Content/css/bootstrap-datepicker.css",
                                 "~/Content/css/style.css")
                                 .Include("~/Content/css/icomoon.css", new CssRewriteUrlTransform())
                                 .Include("~/Content/fonts/flaticon/font/flaticon.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/scripts/layout").Include(
                                 "~/Scripts/jquery.min.js",
                                 "~/Scripts/jquery.easing.1.3.js",
                                 "~/Scripts/bootstrap.min.js",
                                 "~/Scripts/jquery.waypoints.min.js",
                                 "~/Scripts/jquery.flexslider-min.js",
                                 "~/Scripts/owl.carousel.min.js",
                                 "~/Scripts/jquery.magnific-popup.min.js",
                                 "~/Scripts/magnific-popup-options.js",
                                 "~/Scripts/bootstrap-datepicker.js",
                                 "~/Scripts/main.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
