using BusinessLogicLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserBLL _userBLL;

        public AccountController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Entities.User currentUser = new Entities.User();
                currentUser = _userBLL.GetByEmailAndPassword(model.EMail, model.Password);

                if (Session["UserCode"] != null)
                {
                    Guid code = (Guid)Session["UserCode"];
                    bool result = _userBLL.IsActivationCodeRight(code, model.EMail);
                    if (result && currentUser != null)
                    {
                        currentUser.IsActive = true;
                        _userBLL.Update(currentUser);

                        Session["User"] = currentUser;
                        return RedirectToAction("Index", "Teacher");
                    }
                    else
                    {
                        return View(model);
                    }
                }

                if (currentUser != null && currentUser.IsActive)
                {
                    Session["User"] = currentUser;
                    return RedirectToAction("Index", "Teacher");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

        public ActionResult ActivateUser(Guid activationCode)
        {
            Session["UserCode"] = activationCode;
            return View();
        }
    }
}