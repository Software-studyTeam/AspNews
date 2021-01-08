using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNews.Filter;
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
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        
            [HttpPost]
        public ActionResult Login(string UserName, string UserPassword)
        {
            UserDb u = db.UserDb.SingleOrDefault(t => t.UserName == UserName);
            if (u != null)
            {
                if (u.UserPassword == UserPassword)
                {
                    Session["LoginUser"] = u.UserName;
                    Session["Roles"] = u.RightID;
                    return Content("登录成功！<a href='/'>返回首页</a>");
                }
                else
                {
                    Response.Write("<script>alert('用户或密码错误')</script>");
                    return View("Login");
                }
            }
            else
            {
                Response.Write("<script>alert('用户或密码错误')</script>");
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

                Response.Write(("<script>alert('两次密码输入不一致！')</script>"));
                return View();
            }

            if (myuser != null)
            {
                Response.Write(("<script>alert('用户已存在！')</script>"));
                return View();
            }

            UserDb newUser = new UserDb();
            newUser.UserName = UserName;
            newUser.UserPassword = password;
            newUser.RightID = 2;
            db.UserDb.Add(newUser);
            db.SaveChanges();

            Response.Write("<script>alert('注册成功')</script>");
            return View("Login");

        }
        public ActionResult OutLogin()
        {
            Session.Clear();
            return View("Login");
        }
    }
 }