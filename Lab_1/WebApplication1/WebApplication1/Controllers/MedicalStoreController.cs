using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    public class MedicalStoreController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetListMedical()
        {
            return View("MedicalList");
        }
        public IActionResult GetDetailMedical()
        {
            return View("MedicalDetail");
        }
    }
}
