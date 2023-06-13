using System.Diagnostics;
using GreenPath.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenPath.Controllers
{
    public class HomeController : Controller
    {
        HomeModel home = new HomeModel();
        public IActionResult Index()
        {      
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}