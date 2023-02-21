using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace CRMAniventi.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EFProjectDal());
        UserManager um = new UserManager(new EFUserDal());
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        public ActionResult Index()
        {
            var projectvalues = pm.GetProjectList().Where(x => x.ProjectStatus == false);     
                       
            return View(projectvalues);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            List<SelectListItem> valueuser = (from x in um.GetUserList()
                                               select new SelectListItem
                                               {
                                                   Text = x.UserName + " " + x.UserSurname,
                                                   Value = x.UserID.ToString()
                                               }).ToList();
            ViewBag.ulc = valueuser;

            List<SelectListItem> valuecustomer = (from x in cm.GetCustomerList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CustomerName,
                                                      Value = x.CustomerID.ToString()
                                                  }).ToList();
            ViewBag.clc = valuecustomer;

            //List<SelectListItem> currency = (from x in pm.GetProjectList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = x.ProjectCurrency,
            //                                     Value = x.ProjectID.ToString()
            //                                 }).ToList();
            //ViewBag.culc = currency;
            return View();

        }

        [HttpPost]
        public ActionResult AddProject(Project p)
        {
            pm.AddProject(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var projectvalue = pm.GetProjectById(id);
            pm.DeleteProject(projectvalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditProject(int id)
        {
            var projectvalue = pm.GetProjectById(id);
            List<SelectListItem> valueuser = (from x in um.GetUserList()
                                              select new SelectListItem
                                              {
                                                  Text = x.UserName + " " + x.UserSurname,
                                                  Value = x.UserID.ToString()
                                              }).ToList();
            ViewBag.ulc = valueuser;

            List<SelectListItem> valuecustomer = (from x in cm.GetCustomerList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CustomerName,
                                                      Value = x.CustomerID.ToString()
                                                  }).ToList();
            ViewBag.clc = valuecustomer;
            return View(projectvalue);
        }

        [HttpPost]
        public ActionResult EditProject(Project p)
        {
            pm.UpdateProject(p);
            return RedirectToAction("Index");
        }
    }
}