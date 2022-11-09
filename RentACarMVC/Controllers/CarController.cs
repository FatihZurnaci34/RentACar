using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using RentACarMVC.Models;
using System.Collections.Generic;

namespace RentACarMVC.Controllers
{

    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
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
        public IActionResult AddPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(VMCarAdd car)
        {
            var addCar = _mapper.Map<Car>(car);
            _carService.Add(addCar);
            return RedirectToAction("Index", "Car");
        }

        public IActionResult UpdatePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(VMCarUpdate car)
        {
            var updateCar = _mapper.Map<Car>(car);
            _carService.Update(updateCar);
            return RedirectToAction("Index", "Car");
        }

        [HttpPost]
        public IActionResult Delete(Car car)
        {
            
            _carService.Delete(car);
            return RedirectToAction("Index", "Car");
        }

    }
}

