using System.Web;
using System.Web.Optimization;

namespace Eterna
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //tek tek eklemek istersek
            //bundles.Add(new ScriptBundle("~/js/mysite").Include(
            //          "~/Content/js/jquery.js", "~/Content/js/jquery.easing.1.3.js"));


            //*.js uzantısı js olanlar demek
            //true false alt klasörleri al alma demek
            bundles.Add(new ScriptBundle("~/js/mysite").IncludeDirectory("~/Content/js", "*.js", true));
            //contentin içindeki bütün jsleri sıkıştırıyor

            //bundles.Add(new StyleBundle("~/css/mycss").IncludeDirectory("~/Content/css", "*.css", true));
            //@Style.Render("~/css/mycss")


        }
    }
}
