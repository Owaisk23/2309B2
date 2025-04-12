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

        [HttpGet("{id}")]
        public IActionResult GetCar(int id)
        {
            return Ok(db.Cars.Find(id));
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

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, Car updateCar)
        {
            var car = db .Cars.Find(id);
            car.Name = updateCar.Name;
            car.Brand = updateCar.Brand;
            car.Price = updateCar.Price;
            db.Cars.Update(car);
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
