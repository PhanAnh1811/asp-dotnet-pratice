using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TH02.Models;

namespace TH02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.ID = "1";
            product.ProductName = "Iphone X";
            product.ProductType = "64GB";
            product.ProductPrice = 15000000;
            product.Image = "Image/iphone_x_256gb_4.jpg";
            products.Add(product);

            product = new Product();
            product.ID = "2";
            product.ProductName = "Iphone 11 Pro Max";
            product.ProductType = "128GB";
            product.ProductPrice = 20000000;
            products.Add(product);

            product = new Product();
            product.ID = "3";
            product.ProductName = "Iphone 12 Pro Max";
            product.ProductType = "256GB";
            product.ProductPrice = 25000000;
            products.Add(product);

            product = new Product();
            product.ID = "4";
            product.ProductName = "Iphone XS Max";
            product.ProductType = "256GB";
            product.ProductPrice = 22000000;
            products.Add(product);

            product = new Product();
            product.ID = "5";
            product.ProductName = "Iphone XR";
            product.ProductType = "256GB";
            product.ProductPrice = 13000000;
            products.Add(product);

            return View(products);
        }
    }
}
