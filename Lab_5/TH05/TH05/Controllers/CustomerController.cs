using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05.Models;

namespace TH05.Controllers
{
    public class CustomerController : Controller
    {
        DBSportStoreEntities db = new DBSportStoreEntities();
        // GET: Customer
        public ActionResult Index()
        {
            var list = db.Customers.ToList();

            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Error appear when trying to create ");
            }
        }
    }
}