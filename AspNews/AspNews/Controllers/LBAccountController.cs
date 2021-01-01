using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNews.Models.cjl;

namespace AspNews.Controllers
{
    public class LBAccountController : Controller
    {
        News db = new News();
        // GET: LBAccount
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string UserName, string UserPassword)
        {
            UserDb u = db.UserDb.SingleOrDefault(t => t.UserName == UserName);
            if (u != null)
            {
                if (u.UserPassword == UserPassword)
                {
                    Session["LoginUser"] = u.UserName;
                    Session["LoginUser"] = u.RightID;
                    return Redirect("/");
                }
                else
                {
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(string id)
        {
            string UserName = Request.Form["UserName"];
            string ConfirmPassword = Request.Form["ConfirmPassword"];
            string password = Request.Form["UserPassword"];
            UserDb myuser = db.UserDb.FirstOrDefault(u => u.UserName == UserName);
            if (!ConfirmPassword.Equals(password))
            {
                return HttpNotFound();
            }

            if (myuser != null)
            {
                return HttpNotFound();
            }

            UserDb newUser = new UserDb();
            newUser.UserName = UserName;
            newUser.UserPassword = password;
            newUser.RightID = 2;
            db.UserDb.Add(newUser);
            db.SaveChanges();
            return View("Login");

        }
    }
}