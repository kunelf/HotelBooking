using System.Web;
using System.Web.Optimization;

namespace WebSiteHotel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/layout").Include(
                        "~/Content/CssNguoiDungLayout/css/animate.css",
                        "~/Content/CssNguoiDungLayout/css/icomoon.css",
                        "~/Content/CssNguoiDungLayout/css/bootstrap.css",
                        "~/Content/CssNguoiDungLayout/css/magnific-popup.css",
                        "~/Content/CssNguoiDungLayout/css/flexslider.css",
                        "~/Content/CssNguoiDungLayout/css/owl.carousel.min.css",
                        "~/Content/CssNguoiDungLayout/css/owl.theme.default.min.css",
                        "~/Content/CssNguoiDungLayout/css/bootstrap-datepicker.css",
                        "~/Content/CssNguoiDungLayout/fonts/flaticon/font/flaticon.css",
                        "~/Content/CssNguoiDungLayout/css/style.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
