using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RentACarMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService _carService;

        public HomeController(ILogger<HomeController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        public IActionResult Index()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Data);

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
