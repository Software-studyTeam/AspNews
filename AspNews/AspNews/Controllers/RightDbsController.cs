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
    public class RightDbsController : Controller
    {
        private News db = new News();

        // GET: RightDbs
        public ActionResult Index()
        {
            return View(db.RightDb.ToList());
        }

        // GET: RightDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RightDb rightDb = db.RightDb.Find(id);
            if (rightDb == null)
            {
                return HttpNotFound();
            }
            return View(rightDb);
        }

        // GET: RightDbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RightDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RightID,RightName")] RightDb rightDb)
        {
            if (ModelState.IsValid)
            {
                db.RightDb.Add(rightDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rightDb);
        }

        // GET: RightDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RightDb rightDb = db.RightDb.Find(id);
            if (rightDb == null)
            {
                return HttpNotFound();
            }
            return View(rightDb);
        }

        // POST: RightDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RightID,RightName")] RightDb rightDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rightDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rightDb);
        }

        // GET: RightDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RightDb rightDb = db.RightDb.Find(id);
            if (rightDb == null)
            {
                return HttpNotFound();
            }
            return View(rightDb);
        }

        // POST: RightDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RightDb rightDb = db.RightDb.Find(id);
            db.RightDb.Remove(rightDb);
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
