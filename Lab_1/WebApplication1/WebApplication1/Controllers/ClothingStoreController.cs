﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ClothingStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        // ClothingStore/GetListClothings
        public IActionResult GetListClothing()
        {
            return View("ClothingList");
        }
        public IActionResult GetDetailClothing()
        {
            return View("ClotingDetail");
        }
    }
}
