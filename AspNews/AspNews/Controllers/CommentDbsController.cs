using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNews.Models.cjl;

namespace AspNews.Controllers.NewsControllers
{
    public class CommentDbsController : Controller
    {
        private News db = new News();

        // GET: CommentDbs
        public ActionResult Index()
        {
            var commentDb = db.CommentDb.Include(c => c.NewsDb);
            return View(commentDb.ToList());
        }

        // GET: CommentDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentDb commentDb = db.CommentDb.Find(id);
            if (commentDb == null)
            {
                return HttpNotFound();
            }
            return View(commentDb);
        }

        // GET: CommentDbs/Create
        public ActionResult Create()
        {
            ViewBag.NewsId = new SelectList(db.NewsDb, "NewsId", "NewsDescribed");
            return View();
        }

        // POST: CommentDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CommentID,NewsId,UserID,CommentContent,CommentTime")] CommentDb commentDb)
        {
            if (ModelState.IsValid)
            {
                db.CommentDb.Add(commentDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NewsId = new SelectList(db.NewsDb, "NewsId", "NewsDescribed", commentDb.NewsId);
            return View(commentDb);
        }

        // GET: CommentDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentDb commentDb = db.CommentDb.Find(id);
            if (commentDb == null)
            {
                return HttpNotFound();
            }
            ViewBag.NewsId = new SelectList(db.NewsDb, "NewsId", "NewsDescribed", commentDb.NewsId);
            return View(commentDb);
        }

        // POST: CommentDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CommentID,NewsId,UserID,CommentContent,CommentTime")] CommentDb commentDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commentDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NewsId = new SelectList(db.NewsDb, "NewsId", "NewsDescribed", commentDb.NewsId);
            return View(commentDb);
        }

        // GET: CommentDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentDb commentDb = db.CommentDb.Find(id);
            if (commentDb == null)
            {
                return HttpNotFound();
            }
            return View(commentDb);
        }

        // POST: CommentDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommentDb commentDb = db.CommentDb.Find(id);
            db.CommentDb.Remove(commentDb);
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
