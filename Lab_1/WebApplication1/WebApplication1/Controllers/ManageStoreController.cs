using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ManageStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProducts()
        {
            return View("AddMobile");
        }
        public IActionResult EditProducts()
        {
            return View("EditMobile");
        }
        public IActionResult ListProducts()
        {
            return View("List");
        }
    }
}
