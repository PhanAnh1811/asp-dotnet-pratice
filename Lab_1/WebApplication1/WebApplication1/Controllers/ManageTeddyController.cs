﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ManageTeddyController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProducts()
        {
            return View("AddTeddy");
        }
        public IActionResult EditProducts()
        {
            return View("EditTeddy");
        }
        public IActionResult ListProducts()
        {
            return View("ListTeddy");
        }
    }
}
