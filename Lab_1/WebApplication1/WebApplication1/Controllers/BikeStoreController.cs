﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BikeStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetListBike()
        {
            return View("BikeList");
        }
        public IActionResult GetDetailBike()
        {
            return View("BikeDetail");
        }
    }
}
