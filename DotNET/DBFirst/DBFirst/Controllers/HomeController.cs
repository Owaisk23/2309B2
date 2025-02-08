using System.Diagnostics;
using DBFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsContext db;

        public HomeController(ProductsContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        [HttpPost]
        public IActionResult Index(string searchQuery)
        {
            // Retrieve products from the database
            var products = string.IsNullOrEmpty(searchQuery)
            ? db.Products.ToList() // If no search, return all products
                : db.Products
                    .Where(p => p.Name.Contains(searchQuery) || p.Description.Contains(searchQuery))
                    .ToList(); // Search logic

            ViewData["SearchQuery"] = searchQuery; // Pass search query back to view
            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DetailProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
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
