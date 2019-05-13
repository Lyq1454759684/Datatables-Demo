using System.Web;
using System.Web.Optimization;

namespace LYQ.Datatables
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/datatable/css").Include
               ("~/Scripts/bootstrap-v3.3.7/css/bootstrap.min.css"
               , "~/Scripts/datatables-v1.10.18/css/dataTables.bootstrap.min.css"));


            bundles.Add(new ScriptBundle("~/datatable/js").Include
                ("~/Scripts/jquery-v3.3.1/jquery-3.3.1.min.js"
               , "~/Scripts/datatables-v1.10.18/js/jquery.dataTables.min.js"
               , "~/Scripts/datatables-v1.10.18/js/dataTables.bootstrap.min.js"));

        }
    }
}
