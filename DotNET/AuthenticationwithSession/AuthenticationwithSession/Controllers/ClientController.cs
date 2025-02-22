using Microsoft.AspNetCore.Mvc;

namespace AuthenticationwithSession.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            if (HttpContext.Session.GetString("role") == "client")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
    }
}
