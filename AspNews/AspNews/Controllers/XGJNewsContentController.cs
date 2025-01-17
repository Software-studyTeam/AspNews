﻿using AspNews.Models.cjl;
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
            if (id == "" || id == null)
            {
                return HttpNotFound();
            }
            NewsDb testnews = db.NewsDb.Find(id);
            testnews.ReadingNum++;
            db.SaveChanges();
            NewsDb news = new NewsDb();
            news = testnews;
            List<string> content = new List<string>();
            ViewBag.society = db.NewsDb.Where(b => b.TypeID == 1).Select(b => b).ToList();
            ViewBag.internaional = db.NewsDb.Where(b => b.TypeID == 8).Select(b => b).ToList();
            ViewBag.technology = db.NewsDb.Where(b => b.TypeID == 3).Select(b => b).ToList();
            ViewBag.education = db.NewsDb.Where(b => b.TypeID == 9).Select(b=>b).ToList();
            ViewBag.entertainment = db.NewsDb.Where(b => b.TypeID == 7).Select(b => b).ToList();
            string[] Pcontent = news.NewsContent.Split('\n');
            ViewBag.pcontent = Pcontent;
            return View(news);
        }
    }
}