using System.Web.Optimization;

namespace AlexisPambourg
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/plugins/bootstrap-3.3.7-dist/css/bootstrap.css",
                      "~/Content/css/theme.css",
                      "~/Content/css/generic.css",
                      "~/Content/css/custom.css"));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/plugins/jquery-3.1.1/jquery-3.1.1.js",
                "~/Content/plugins/modernizr-2.6.2/modernizr-2.6.2.js",
                "~/Content/plugins/jquery-validation-1.16.0/dist/jquery.validate.js",
                "~/Content/plugins/bootstrap-3.3.7-dist/js/bootstrap.js",
                "~/Content/plugins/respond-1.4.2/respond.js"));
        }
    }
}