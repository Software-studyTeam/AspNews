using System.Web;
using System.Web.Optimization;

namespace AspNews
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // 以下每一项功能所依赖的NuGet程序包及其版本在括号中给出。
            //    jQuery 最新版 v3.5.1 会导致部分例子过时
            //    Bootstrap v4.x 也类似。
            //    要使例子能运行，不能过分追求新版本的程序包■

            //jquery基本功能
            // (1. jQuery v3.4.1)
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //jquery的非介入式ajax 
            // (2. Microsoft.jQuery.Unobtrusive.Ajax v3.2.3)
            // (3. Microsoft.jQuery.Unobtrusive.Validation v3.2.3)
            bundles.Add(new ScriptBundle("~/bundles/jquery/unobtrusive-ajax").Include("~/Scripts/jquery.unobtrusive*"));

            //jquery客户端验证
            // (4. jQuery.Validation v1.13.1)
            bundles.Add(new ScriptBundle("~/bundles/jquery/validate").Include("~/Scripts/jquery.validate*"));

            //jqueryUI脚本
            // (5. jQuery.UI.Combined v1.11.4)
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                         "~/Scripts/jquery-ui-{version}.js",
                         "~/Scripts/jquery-ui-datepicker-cn.js"
                         )); //*datepicker* 不必单独引用，可去掉

            //开发和调试程序用的 Modernizr 的版本
            // (6. Modernizr v2.8.3)
            //实际发布前，可使用 http://modernizr.com 上的生成工具简化要检测的项。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Bootstrap和respond脚本
            // (7. Bootstrap v3.3.2)
            // (8. Respond v1.4.2)
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //模板默认使用的CSS文件
            //  如果建空网站, Site.css需要自己创建
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            //jqueryUI的CSS文件
            bundles.Add(new StyleBundle("~/Content/themes/base/jquery-ui").Include(
                      "~/Content/themes/base/all.css"));

            //true表示自动进行捆绑【将js全部捆绑到一个文件中】和缩小【自动选择.min.*的文件】。
            //    这种方式由于缩小了文件大小和加载文件的次数，因此加载速度稍快，但调试困难。
            //false表示不进行捆绑和缩小。
            BundleTable.EnableOptimizations = true;
        }
    }
}

