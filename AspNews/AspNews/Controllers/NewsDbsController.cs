using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNews.Filter;
using AspNews.Models.cjl;

namespace AspNews.Controllers.NewsControllers
{
    [Administration]
    public class NewsDbsController : Controller
    {
        private News db = new News();

        // GET: NewsDbs
        public ActionResult Index()
        {
            return View(db.NewsDb.ToList());
        }

        // GET: NewsDbs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsDb newsDb = db.NewsDb.Find(id);
            if (newsDb == null)
            {
                return HttpNotFound();
            }
            return View(newsDb);
        }
        [HttpGet]
        [Administration]
        // GET: NewsDbs/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Administration]
        public ActionResult Create(string id)
        {
            
            string NewsTitle = Request.Form["NewsTitle"];
            string NewsDescribed = Request.Form["NewsDescribed"];
            string NewsContent = Request.Form["NewsContent"];
            string TypeName = Request.Form["TypeDb.TypeName"];
            string RankName = Request.Form["RankDb.RankName"];
            string NewsKeywords = Request.Form["NewsKeywords"];
            string NewsSource = Request.Form["NewsSource"];
            string NewsWriter = Request.Form["NewsWriter"];

            string FilmTypeID = Request.Form["FilmTypeID"];
            string url = Request.Files["file0"].FileName;
            string FileName = DateTime.Now.ToString("yyyyMMddhhmmss");
            string NewsId=FileName;
            NewsDb new1 = new NewsDb();
            if (url != "")
            {
                HttpPostedFileBase file = Request.Files["file0"];
                
                string FileUrl = "Image/News/" + FileName + ".jpg";
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/png")
                {
                    //string Path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                    file.SaveAs(Server.MapPath("~/Image/News/" + FileName + ".jpg"));
                }

                new1.ImageURL = FileUrl;
            }
            new1.ReadingNum = 0;
            new1.NewsId = NewsId;
            new1.NewsTitle = NewsTitle;
            new1.NewsDescribed = NewsDescribed;
            new1.NewsKeywords = NewsKeywords;
            new1.NewsSource = NewsSource;
            new1.NewsWriter = NewsWriter;
            new1.ReleaseTime = DateTime.Now;
            new1.NewsContent = NewsContent;
            new1.TypeID = db.TypeDb.FirstOrDefault(b => b.TypeName == TypeName).TypeID;
            new1.RankID = db.RankDb.FirstOrDefault(b => b.RankName == RankName).RankID;
            db.NewsDb.Add(new1);
            db.SaveChanges();
            if (ModelState.IsValid)
            {
                db.Entry(new1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            if (Request.IsAjaxRequest())
                return PartialView(new1);
            else
                return View(new1);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            string NewsId = Request.Form["NewsId"];
            string NewsTitle = Request.Form["NewsTitle"];
            string NewsDescribed = Request.Form["NewsDescribed"];
            string NewsContent = Request.Form["NewsContent"];
            string TypeName = Request.Form["TypeDb.TypeName"];
            string RankName = Request.Form["RankDb.RankName"];
            string NewsKeywords = Request.Form["NewsKeywords"];
            string NewsSource = Request.Form["NewsSource"];
            string NewsWriter = Request.Form["NewsWriter"];
            string ReleaseTime = Request.Form["ReleaseTime"];
            DateTime dt = Convert.ToDateTime(ReleaseTime);
            string FilmTypeID = Request.Form["FilmTypeID"];
            string url = Request.Files["file0"].FileName;
            NewsDb new1 = db.NewsDb.SingleOrDefault(g => g.NewsId == NewsId);
            if (url != "")
            {
                HttpPostedFileBase file = Request.Files["file0"];
                string FileName = DateTime.Now.ToString("yyyyMMddhhmmss");
                string FileUrl = "Image/News/" + FileName + ".jpg";
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/png")
                {
                    //string Path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                    file.SaveAs(Server.MapPath("~/Image/News/" + FileName + ".jpg"));
                }

                new1.ImageURL = FileUrl;
            }
            new1.NewsTitle = NewsTitle;
            new1.NewsDescribed = NewsDescribed;
            new1.NewsKeywords = NewsKeywords;
            new1.NewsSource = NewsSource;
            new1.NewsWriter = NewsWriter;
            new1.ReleaseTime = dt;
            new1.NewsContent = NewsContent;
            new1.TypeID = db.TypeDb.FirstOrDefault(b=>b.TypeName== TypeName).TypeID;
            new1.RankID = db.RankDb.FirstOrDefault(b => b.RankName == RankName).RankID;

            db.SaveChanges();
            if (ModelState.IsValid)
            {
                db.Entry(new1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            if (Request.IsAjaxRequest())
                return PartialView(new1);
            else
                return View(new1);
        }
        [Administration(FailView = "Index")]
        [HttpGet]
        // GET: NewsDbs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsDb newsDb = db.NewsDb.Find(id);
            if (newsDb == null)
            {
                return HttpNotFound();
            }
            return View(newsDb);
        }

 

        // GET: NewsDbs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsDb newsDb = db.NewsDb.Find(id);
            if (newsDb == null)
            {
                return HttpNotFound();
            }
            return View(newsDb);
        }

        // POST: NewsDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NewsDb newsDb = db.NewsDb.Find(id);
            db.NewsDb.Remove(newsDb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
