﻿using System.Web;
using System.Web.Optimization;

namespace EPos.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                    "~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Content/ionicons").Include(
                      "~/Content/ionicons.min.css"));
            bundles.Add(new StyleBundle("~/Content/adminLTE").Include(
                      "~/Content/AdminLTE.min.css"));
            bundles.Add(new StyleBundle("~/Content/allskins").Include(
                      "~/Content/_all-skins.min.css"));
            bundles.Add(new StyleBundle("~/Content/site").Include(
                      "~/Content/site.css"));



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                      "~/Scripts/jquery.slimscroll.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/fastclick").Include(
                      "~/Scripts/fastclick.js"));
            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                      "~/Scripts/adminlte.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                      "~/Scripts/demo.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-val").Include(
                      "~/Scripts/jquery.validate.min.js", "~/Scripts/jquery.validate.unobtrusive.min.js"));

            //Dasboard Scripts

            bundles.Add(new StyleBundle("~/Content/jquery-jvectormap").Include(
                     "~/Content/jquery-jvectormap.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.sparkline").Include(
                "~/Scripts/jquery.sparkline.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-jvectormap").Include(
                "~/Scripts/jquery-jvectormap-1.2.2.min.js", "~/Scripts/jquery-jvectormap-world-mill-en.js"));
            bundles.Add(new ScriptBundle("~/bundles/Chart").Include(
                          "~/Scripts/Chart.js"));
            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                          "~/Scripts/dashboard2.js"));
        }
    }
}
