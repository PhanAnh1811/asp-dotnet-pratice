using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05.Models;

namespace TH05.Controllers
{
    public class ProductController : Controller
    {
        DBSportStoreEntities database = new DBSportStoreEntities();
        // GET: Product
        public ActionResult Index(string category)
        {
            if (category == null)
            {
                var data = database.Products.OrderByDescending(x=>x.NamePro);
                return View(data);
            }
            else
            {
                var productList = database.Products.OrderByDescending(x => x.NamePro)
                .Where(x => x.Category == category);
                return View(productList.ToList());
            }
        }
    }
}