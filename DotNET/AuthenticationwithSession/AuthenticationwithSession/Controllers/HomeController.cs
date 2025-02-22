using AuthenticationwithSession.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthenticationwithSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View();
            if (HttpContext.Session.GetString("role") == "user")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
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