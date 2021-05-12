using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BookStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetListBook()
        {
            return View("BookList");
        }
        public IActionResult GetDetailBook()
        {
            return View("BookDetail");
        }
    }
}
