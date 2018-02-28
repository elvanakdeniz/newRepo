using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.MVC.Filter
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public string UserRole { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["User"] == null)
            {
                return false;
            }

            Entities.User currentUser = httpContext.Session["User"] as Entities.User;
            if (UserRole.Contains(currentUser.UserRole.RoleName))
            {
                return true;
            }

            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"] == null)
            {
                filterContext.Result = new RedirectResult("/Account/LogIn");
            }
            else
            {
                filterContext.Result = new RedirectResult("/Account/LogIn");
            }
        }
    }
}