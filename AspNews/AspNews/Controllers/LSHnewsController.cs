using AspNews.Models.cjl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNews.Controllers
{
    public class LSHnewsController : Controller
    {
        private News db = new News();
        // GET: LSHnews
        public ActionResult Index(string Id)
        {
            List<NewsDb> news = db.NewsDb.Where(b => b.TypeID == 2).ToList();

            
            return View(Id,news);
        }
    }
}