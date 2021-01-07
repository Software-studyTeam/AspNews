using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNews.Filter;
using AspNews.Models.cjl;

namespace AspNews.Controllers.NewsControllers
{
    //[CheckUser]
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

        // GET: NewsDbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewsId,TypeID,RankID,NewsDescribed,NewsWriter,NewsTitle,NewsSource,NewsKeywords,ReleaseTime,NewsContent,ImageURL,ReadingNum")] NewsDb newsDb)
        {
            if (ModelState.IsValid)
            {
                db.NewsDb.Add(newsDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsDb);
        }

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

        // POST: NewsDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NewsId,TypeID,RankID,NewsDescribed,NewsWriter,NewsTitle,NewsSource,NewsKeywords,ReleaseTime,NewsContent,ImageURL,ReadingNum")] NewsDb newsDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
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
