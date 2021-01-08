using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNews.Filter
{
    public class AdministrationAttribute: System.Web.Mvc.ActionFilterAttribute
    {
        public string FailView { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["Roles"] != null)
            {
                if (HttpContext.Current.Session["Roles"].Equals(1))
                {

                    return ;
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>alert('权限不足')</script>");
                    filterContext.Result = new RedirectResult("/LBAccount/Login");                }

            
            }
            else
            {
                HttpContext.Current.Response.Write("<script>alert('请先登录')</script>");
                filterContext.Result = new RedirectResult("/LBAccount/Login");
            }
        }
    }
}