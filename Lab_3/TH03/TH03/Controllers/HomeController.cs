using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH03.Models;

namespace TH03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> list = new List<Product>()
            {
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},
                 new Product { ProductID = "1",ProductName="ASP DOTNET",ProductImage="https://th.bing.com/th/id/OIP.GtqJWHbL_0_BBOlS-hlTPAHaHa?pid=ImgDet&rs=1",ProductPrice="200000VND",ProductQuantity="10"},

            };
            ViewBag.ListProduct = list;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}