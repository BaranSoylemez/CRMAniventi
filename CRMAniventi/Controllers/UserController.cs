using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMAniventi.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EFUserDal());
        public ActionResult Index()
        {
            var uservalues = um.GetUserList();
            return View(uservalues);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User p)
        {
            um.AddUser(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteUser(int id)
        {
            var uservalues = um.GetUserById(id);
            um.DeleteUser(uservalues);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditUser(int id)
        {
            var uservalue = um.GetUserById(id);
            return View(uservalue);
        }

        [HttpPost]
        public ActionResult EditUser(User user)
        {
            um.UpdateUser(user);
            return RedirectToAction("Index");
        }
    }
}