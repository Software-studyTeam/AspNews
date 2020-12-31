using AspNews.Models.cjl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNews.Controllers
{
    public class XGJNewsContentController : Controller
    {
        private News db = new News();
        // GET: XGJNewsContent
        public ActionResult Index(string id)
        {
            NewsDb testnews = db.NewsDb.Find("1");
            NewsDb news = new NewsDb();
            news = testnews;
            List<string> content = new List<string>();
            string[] Pcontent = news.NewsContent.Split('\n');
            ViewBag.pcontent = Pcontent;
            // news.NewsId ="qwe123";
            // news.TypeID = 3;
            // news.ReleaseTime = DateTime.Parse("2020-12-29");
            // news.ReadingNum = 32434;
            // news.NewsWriter = "李冰冰";
            // news.NewsTitle = "新华网评：京津冀协同发展驶入快车道";
            // news.NewsDescribed = "12月27日，联通两地的京雄城际铁路全线开通运营，自此，从北京西站至雄安新区最快仅需50分钟，大兴机场至雄安新区间最快19分钟可达。";
            // news.NewsKeywords = "京津冀,协同发展";
            // news.NewsSource = "央视新闻网";
            // news.NewsContent = "";
            return View(news);
        }
    }
}