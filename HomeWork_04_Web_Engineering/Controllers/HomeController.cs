using System.Diagnostics;
using HomeWork_04_Web_Engineering.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_04_Web_Engineering.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
