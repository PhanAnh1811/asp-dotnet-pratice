using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateSimpleInterestResult()
        {
            decimal principle = Convert.ToDecimal(Request["txtAmount"].ToString());
            return View();
        }

    }
}
