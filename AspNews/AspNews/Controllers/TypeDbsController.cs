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
    public class TypeDbsController : Controller
    {
        private News db = new News();

        // GET: TypeDbs
        public ActionResult Index()
        {
            return View(db.TypeDb.ToList());
        }

        // GET: TypeDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDb typeDb = db.TypeDb.Find(id);
            if (typeDb == null)
            {
                return HttpNotFound();
            }
            return View(typeDb);
        }

        // GET: TypeDbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeDbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeID,TypeName")] TypeDb typeDb)
        {
            if (ModelState.IsValid)
            {
                db.TypeDb.Add(typeDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeDb);
        }

        // GET: TypeDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDb typeDb = db.TypeDb.Find(id);
            if (typeDb == null)
            {
                return HttpNotFound();
            }
            return View(typeDb);
        }

        // POST: TypeDbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeID,TypeName")] TypeDb typeDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeDb);
        }

        // GET: TypeDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDb typeDb = db.TypeDb.Find(id);
            if (typeDb == null)
            {
                return HttpNotFound();
            }
            return View(typeDb);
        }

        // POST: TypeDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeDb typeDb = db.TypeDb.Find(id);
            db.TypeDb.Remove(typeDb);
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
