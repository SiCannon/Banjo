﻿using System.Web.Optimization;

namespace Banjo.Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular-lib")
                .Include("~/Scripts/angular.js")
                .Include("~/JsSc/Modules/ScModule.js")
                .IncludeDirectory("~/JsSc", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/angular-banjo")
                .Include("~/JsBanjo/Modules/BanjoApp.js")
                .IncludeDirectory("~/JsBanjo", "*.js", true));

            var fa = new Bundle("~/bundles/font-awesome")
                .Include("~/Styles/font-awesome/font-awesome.less");
            fa.Transforms.Add(new LessTransform("~/Styles/font-awesome"));
            fa.Transforms.Add(new CssMinify());
            bundles.Add(fa);

            var less = new Bundle("~/bundles/less").Include("~/Styles/node.less");
            less.Transforms.Add(new LessTransform("~/Styles"));
            less.Transforms.Add(new CssMinify());
            bundles.Add(less);
        }
    }
}