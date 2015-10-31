using System.Web.Optimization;

namespace Banjo.Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular-lib")
                .Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-banjo")
                .Include("~/JsBanjo/Modules/BanjoApp.js")
                .IncludeDirectory("~/JsBanjo", "*.js", true));
        }
    }
}