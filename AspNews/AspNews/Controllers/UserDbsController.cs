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
    public class UserDbsController : Controller
    {
        private News db = new News();

        // GET: UserDbs
        public ActionResult Index()
        {
            var userDb = db.UserDb.Include(u => u.RightDb);
            return View(userDb.ToList());
        }

        // GET: UserDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDb userDb = db.UserDb.Find(id);
            if (userDb == null)
            {
                return HttpNotFound();
            }
            return View(userDb);
        }

        // GET: UserDbs/Create
        public ActionResult Create()
        {
            ViewBag.RightID = new SelectList(db.RightDb, "RightID", "RightName");
            return View();
        }

        // POST: UserDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,UserName,RightID,UserPassword")] UserDb userDb)
        {
            if (ModelState.IsValid)
            {
                db.UserDb.Add(userDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RightID = new SelectList(db.RightDb, "RightID", "RightName", userDb.RightID);
            return View(userDb);
        }

        // GET: UserDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDb userDb = db.UserDb.Find(id);
            if (userDb == null)
            {
                return HttpNotFound();
            }
            ViewBag.RightID = new SelectList(db.RightDb, "RightID", "RightName", userDb.RightID);
            return View(userDb);
        }

        // POST: UserDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,UserName,RightID,UserPassword")] UserDb userDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RightID = new SelectList(db.RightDb, "RightID", "RightName", userDb.RightID);
            return View(userDb);
        }

        // GET: UserDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDb userDb = db.UserDb.Find(id);
            if (userDb == null)
            {
                return HttpNotFound();
            }
            return View(userDb);
        }

        // POST: UserDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserDb userDb = db.UserDb.Find(id);
            db.UserDb.Remove(userDb);
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
