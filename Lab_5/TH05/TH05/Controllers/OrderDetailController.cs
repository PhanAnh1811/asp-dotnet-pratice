using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TH05.Models;

namespace WebApplication3.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: OrderDetail

        DBSportStoreEntities db = new DBSportStoreEntities();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GroupByTop5()
        {
            List<OrderDetail> orderD = db.OrderDetails.ToList();
            List<Product> proList = db.Products.ToList();

            var query = from od in orderD
                        join p in proList
                        on od.IDProduct equals p.ProductID into tbl
                        group od by new
                        {
                            idPro = od.Product.ProductID,
                            imagePro = od.Product.ImagePro,
                            price = od.Product.Price,
                            namePro = od.Product.NamePro
                        } into gr
                        orderby gr.Sum(s => s.Quantity) descending
                        select new ViewModel
                        {
                            IDPro = gr.Key.idPro,
                            NamePro = gr.Key.namePro,
                            ImgPro = gr.Key.imagePro,
                            pricePro = (decimal)gr.Key.price,
                            Sum_Quantity = gr.Sum(s => s.Quantity)
                        };

            return View(query.Take(5).ToList());

        }
    }
}