using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ValuesAddByMVC.Controllers
{
    public class ValuesAddController : Controller
    {
        int Value1, Value2;
        public IActionResult Index()
        {
            ViewBag.Value1 = Value1;
            ViewBag.Value2 = Value2;
            return View();
        }
        [HttpPost]
        public IActionResult add()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["value1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["value2"].ToString());
            int result = num1 + num2;
            ViewBag.Value1 = num1;
            ViewBag.Value2 = num2;
            ViewBag.SumResult = result.ToString();
            return View("Index");
        }
    }
}