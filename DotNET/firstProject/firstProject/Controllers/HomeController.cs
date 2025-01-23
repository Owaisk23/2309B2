using System.Diagnostics;
using firstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstProject.Controllers
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
            TempData["phoneno"] = "+923102235827";
            TempData.Keep();
            ViewBag.car = "Honda Civic";
            return View();
        }
        public IActionResult About()
        {
            ViewData["stdname1"] = "Ayan Shakeel";
            ViewData["stdname2"] = "Luqman Aslam";
            ViewData["stdname3"] = "Sami";
            ViewData["stdname4"] = "Ayan Sheikh";
            return View();
        }
        public IActionResult ContactUS()
        {
            TempData.Keep();
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
