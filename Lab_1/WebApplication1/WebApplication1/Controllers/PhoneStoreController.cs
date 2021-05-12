using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    public class PhoneStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetListPhone()
        {
            return View("PhoneList");
        }
        public IActionResult GetDetailPhone()
        {
            return View("PhoneDetail");
        }
    }
}
