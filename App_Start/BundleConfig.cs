﻿using System.Web;
using System.Web.Optimization;

namespace ExamVoid
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.min.css","~/Content/Site.css"));
            bundles.Add(new ScriptBundle("~/Scripts/css").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include("~/Scripts/jquery.min.js"));
        }
    }
}
