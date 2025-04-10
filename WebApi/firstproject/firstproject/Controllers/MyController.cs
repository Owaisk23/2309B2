using firstproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly CarsContext db;

        public MyController(CarsContext _db)
        {

            db = _db;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(db.Cars.ToList());
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {

            db.Cars.Add(car);
            db.SaveChanges();
            return StatusCode(201);

        }

        [HttpDelete]
        public IActionResult DeleteCar(int id)
        {
            var car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return StatusCode(201);
        }




        //[HttpGet]
        //public IActionResult GetName()
        //{
        //    return Ok("Owais Ahmed Khan");
        //}
        //[HttpGet]
        //public IActionResult GetUSer()
        //{
        //    return Ok("Owais Ahmed Khan");
        //}
    }
}
