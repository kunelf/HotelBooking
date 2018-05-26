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

            bundles.Add(new ScriptBundle("~/scripts/layout").Include(
                      "~/Content/CssNguoiDungLayout/js/jquery.min.js",
                      "~/Content/CssNguoiDungLayout/js/jquery.easing.1.3.js",
                      "~/Content/CssNguoiDungLayout/js/bootstrap.min.js",
                      "~/Content/CssNguoiDungLayout/js/jquery.waypoints.min.js",
                      "~/Content/CssNguoiDungLayout/js/jquery.flexslider-min.js",
                      "~/Content/CssNguoiDungLayout/js/owl.carousel.min.js",
                      "~/Content/CssNguoiDungLayout/js/jquery.magnific-popup.min.js",
                      "~/Content/CssNguoiDungLayout/js/magnific-popup-options.js",
                      "~/Content/CssNguoiDungLayout/js/bootstrap-datepicker.js",
                      "~/Content/CssNguoiDungLayout/js/main.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
