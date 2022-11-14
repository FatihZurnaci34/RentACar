using AutoMapper;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACarMVC.Models;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;

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
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Car car)
        {
            Common obj = new Common();
            string temp = obj.PutData("https://localhost:44316/api/cars/update" ,car);
            var input = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Car car)
        {

            Common cmn = new Common();
            string temp = cmn.DeleteData("https://localhost:44316/api/cars/delete",car);
            var input = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);

            return RedirectToAction(nameof(Index));
        }

    }
}

