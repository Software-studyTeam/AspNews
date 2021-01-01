using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNews.Filter
{
    public class CheckUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["LoginUser"] == null)
            {
                filterContext.Result = new RedirectResult("/LBAccount/Login");
            }

        }
    }
}