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
