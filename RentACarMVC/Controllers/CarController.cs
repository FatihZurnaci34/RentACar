using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RentACarMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Data);
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return RedirectToAction("Index", "Car");
            }
            return View();
        }
    }
}

