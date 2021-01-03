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
        public ActionResult Index(string id)
        {
            int idnum = int.Parse(id);
            List<NewsDb> news = db.NewsDb.Where(b => b.TypeID == idnum).ToList();

            ViewBag.thisEntitle = db.TypeDb.Find(idnum).TypeEnName;
            ViewBag.thistitle = db.TypeDb.Find(idnum).TypeName;
            
            return View(news);
        }
    }
}