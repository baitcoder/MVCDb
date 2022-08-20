using System;
using Microsoft.AspNetCore.Mvc;

namespace MVCDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message;
                return View("Error");
            }
            return View();
            
        }
    }
}
