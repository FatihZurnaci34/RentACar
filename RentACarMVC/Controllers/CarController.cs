using Business.Abstract;
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
    }
}
