using System.Web.Optimization;

namespace AngularMvcStarter
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/angular").Include(
                "~/lib/angular/angular.js",
                "~/lib/angular-resource/angular-resource.js"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/lib/bootstrap/dist//css/bootstrap.css",
                      "~/css/site.css"));
        }
    }
}
