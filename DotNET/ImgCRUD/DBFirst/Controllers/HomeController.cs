﻿using DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

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

        public IActionResult Create()
        {
            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatName");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product item, IFormFile file)
        {
            var imageName = DateTime.Now.ToString("yymmddhhmmss");//25022255454454
            imageName += Path.GetFileName(file.FileName);//24074455454454apple.png

            string imagepath = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/Uploads");
            var imagevalue = Path.Combine(imagepath, imageName);

            using (var stream = new FileStream(imagevalue, FileMode.Create))
            {

                file.CopyTo(stream);

            }

            var dbimage = Path.Combine("/Uploads", imageName);//   /uploads/240715343434pixel.png
            item.Image = dbimage;

            db.Products.Add(item);
            db.SaveChanges();


            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatName");
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatName");
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