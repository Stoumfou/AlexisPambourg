using System.Web.Optimization;

namespace AlexisPambourg
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/plugins/jquery-3.1.1/jquery-3.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/plugins/jquery-validation-1.16.0/dist/jquery.validate.js"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/plugins/modernizr-2.6.2/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/plugins/bootstrap-3.3.7-dist/js/bootstrap.js",
                      "~/Content/plugins/respond-1.4.2/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/plugins/bootstrap-3.3.7-dist/css/bootstrap.css",
                      "~/Content/css/theme.css",
                      "~/Content/css/generic.css",
                      "~/Content/css/custom.css"));
        }
    }
}