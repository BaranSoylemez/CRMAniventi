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
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        
        public ActionResult Index()
        {
            var customervalues = cm.GetCustomerList();
            return View(customervalues);
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer p)
        {
            cm.AddCustomer(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCustomer(int id)
        {
            var customervalue = cm.GetCustomerById(id);
            cm.DeleteCustomer(customervalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var customervalue = cm.GetCustomerById(id);
            return View(customervalue);
        }

        [HttpPost]
        public ActionResult EditCustomer(Customer p)
        {
            cm.UpdateCustomer(p);
            return RedirectToAction("Index");
        }

    }
}