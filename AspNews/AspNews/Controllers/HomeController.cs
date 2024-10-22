﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AspNews.Models.cjl;
using AspNews.cs;
using AspNews.Filter;

namespace AspNews.Controllers
{

    public class HomeController : Controller

    {
        private News db = new News();

        //[CheckUser]
        public ActionResult InitNews()
        {
            News db = new News();
            NewsInitAlways context = new NewsInitAlways();
            context.InitializeDatabase(db);
            ViewBag.Count1 = db.RightDb.Count();
            ViewBag.Count2 = db.UserDb.Count();
            ViewBag.Count3 = db.RankDb.Count();
            ViewBag.Count4 = db.CommentDb.Count();
            ViewBag.Count5 = db.TypeDb.Count();
            ViewBag.Count6 = db.NewsDb.Count();
            return PartialView();

        }

        public ActionResult Index()
        {
            if (db.NewsDb.Count() == 0)
            {
                News db = new News();
                NewsInitAlways context = new NewsInitAlways();
                context.InitializeDatabase(db);
            }

            List<NewsDb> news = db.NewsDb.OrderByDescending(b => b.ReleaseTime).Take(30).ToList();
            ViewBag.NewsMains = db.NewsDb.OrderBy(b=>b.RankID).Take(10).ToList();
            ViewBag.NewsMove = db.NewsDb.OrderByDescending(b => b.ReadingNum).Take(4).ToList();
            return View(news);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}