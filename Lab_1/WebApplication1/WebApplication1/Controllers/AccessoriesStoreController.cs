using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AccessoriesStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetListAccessories()
        {
            return View("AccessoriesList");
        }
        public IActionResult GetDetailAccessories()
        {
            return View("AccessoriesDetail");
        }
    }
}
