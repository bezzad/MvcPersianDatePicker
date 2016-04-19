using System.Web;
using System.Web.Optimization;

namespace PersianDatePicker
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/PersianDateTimePicker").Include("~/Scripts/MdBootstrapPersianDateTimePicker/jquery.Bootstrap-PersianDateTimePicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/jalaali").Include("~/Scripts/MdBootstrapPersianDateTimePicker/jalaali.js"));


            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.min.css"));
            
            bundles.Add(new StyleBundle("~/Content/PersianDateTimePicker").Include("~/Content/MdBootstrapPersianDateTimePicker/jquery.Bootstrap-PersianDateTimePicker.min.css"));
        }
    }
}
