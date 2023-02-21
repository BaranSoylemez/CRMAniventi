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
    public class QuoteController : Controller
    {
        QuoteManager qm = new QuoteManager(new EFQuoteDal());
        ProjectManager pm = new ProjectManager(new EFProjectDal());
        UserManager um = new UserManager(new EFUserDal());
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        public ActionResult Index()
        {
            var quotevalue = qm.GetQuoteList();
            return View(quotevalue);
        }

        [HttpGet]
        public ActionResult AddQuote(int id)
        {
            //List<SelectListItem> valueproject = (from x in pm.GetProjectList()
            //                                     select new SelectListItem
            //                                     {
            //                                         Text = x.ProjectName,
            //                                         Value = x.ProjectID.ToString()
            //                                     }).ToList();
            //ViewBag.plc = valueproject;

            //List<SelectListItem> valuecustomer = (from x in cm.GetCustomerList()
            //                                      select new SelectListItem
            //                                      {
            //                                          Text = x.CustomerName,
            //                                          Value = x.CustomerID.ToString()
            //                                      }).ToList();
            //ViewBag.clc = valuecustomer;

            //List<SelectListItem> valueuser = (from x in um.GetUserList()
            //                                  select new SelectListItem
            //                                  {
            //                                      Text = x.UserName + " " + x.UserSurname,
            //                                      Value = x.UserID.ToString()
            //                                  }).ToList();
            //ViewBag.ulc = valueuser;
            var idproject=pm.GetProjectById(id);
            return View(idproject);
        }

        [HttpPost]
        public ActionResult AddQuote(Quote p)
        {
            qm.AddQuote(p);
            return RedirectToAction("Index");
        }
    }
}