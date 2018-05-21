using System.Web.Optimization;

namespace GuimaraesTecnhology.Semantic_Ui
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/basic").Include(
                "~/Content/semantic.css"));

            bundles.Add(new ScriptBundle("~/bundles/basic").Include(
                "~/Scripts/semantic.js"));
        }
    }
}