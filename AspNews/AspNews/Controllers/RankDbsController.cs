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
    public class RankDbsController : Controller
    {
        private News db = new News();

        // GET: RankDbs
        public ActionResult Index()
        {
            return View(db.RankDb.ToList());
        }

        // GET: RankDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RankDb rankDb = db.RankDb.Find(id);
            if (rankDb == null)
            {
                return HttpNotFound();
            }
            return View(rankDb);
        }

        // GET: RankDbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RankDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RankID,RankName,RankDescribed")] RankDb rankDb)
        {
            if (ModelState.IsValid)
            {
                db.RankDb.Add(rankDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rankDb);
        }

        // GET: RankDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RankDb rankDb = db.RankDb.Find(id);
            if (rankDb == null)
            {
                return HttpNotFound();
            }
            return View(rankDb);
        }

        // POST: RankDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RankID,RankName,RankDescribed")] RankDb rankDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rankDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rankDb);
        }

        // GET: RankDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RankDb rankDb = db.RankDb.Find(id);
            if (rankDb == null)
            {
                return HttpNotFound();
            }
            return View(rankDb);
        }

        // POST: RankDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RankDb rankDb = db.RankDb.Find(id);
            db.RankDb.Remove(rankDb);
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
