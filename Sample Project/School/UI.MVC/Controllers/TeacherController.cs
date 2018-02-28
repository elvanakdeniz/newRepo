using BusinessLogicLayer.Abstract;
using Entities;
using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.MVC.Filter;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    [CustomAuthorize(UserRole="Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherBLL _teacherBLL;
        private readonly IUserBLL _userBLL;
        private readonly IUserRoleBLL _userRoleBLL;

        public TeacherController(ITeacherBLL teacherBLL, IUserBLL userBLL, IUserRoleBLL userRoleBLL)
        {
            _teacherBLL = teacherBLL;
            _userBLL = userBLL;
            _userRoleBLL = userRoleBLL;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacher(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                Teacher t = new Teacher()
                {
                    Firstname = model.Teacher.Firstname,
                    LastName = model.Teacher.LastName
                };
                _teacherBLL.Insert(t);

                Guid code = Guid.NewGuid();
                Entities.User u = new User()
                {
                    Firstname = t.Firstname,
                    Lastname = t.LastName,
                    EMail = model.User.EMail,
                    Password = model.User.Password,
                    UserRoleID = _userRoleBLL.GetByRoleName("Standart").UserRoleID,
                     ActivationCode = code
                };
                _userBLL.Insert(u);

                MailHelper.SendMail(u.EMail, code);

                return RedirectToAction("Index");
            }
            return View();
        }
	}
}