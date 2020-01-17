using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ValuesAddByMVC.Controllers
{
    public class ValuesAddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["value1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["value2"].ToString());
            int result = num1 + num2;
            ViewBag.SumResult = result.ToString();
            return View("Index");
        }
    }
}