using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05.Models;
using PagedList;
using PagedList.Mvc;

namespace TH05.Controllers
{
    public class ProductController : Controller
    {
        DBSportStoreEntities database = new DBSportStoreEntities();
        // GET: Product
        public ActionResult Index(string category, int? page)
        {
            int pageSize = 4;
            int pageNum = (page ?? 1);
            if (category == null)
            {
                var productList = database.Products.OrderByDescending(x=>x.NamePro);
                return View(productList.ToPagedList(pageNum,pageSize));
            }
            else
            {
                var productList = database.Products.OrderByDescending(x => x.NamePro)
                .Where(x => x.Category == category);
                return View(productList.ToList());
            }
        }

        public ActionResult SearchOption(double min=double.MinValue, double max = double.MaxValue)
        {
            var list = database.Products.Where(p => (double)p.Price >= min && (double)p.Price <= max).ToList();
            return View(list);
        }
    }
}