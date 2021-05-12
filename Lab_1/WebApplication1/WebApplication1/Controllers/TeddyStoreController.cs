using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class TeddyStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetListTeddy()
        {
            return View("TeddyList");
        }
        public IActionResult GetDetailTeddy()
        {
            return View("TeddyDetail");
        }
    }
}
