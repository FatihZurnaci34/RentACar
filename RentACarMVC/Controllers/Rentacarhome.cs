﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RentACarMVC.Controllers
{
    public class Rentacarhome : Controller
    {
        IPopularCarService _popularCarService;

        public Rentacarhome(IPopularCarService popularCarService)
        {
            _popularCarService = popularCarService;
        }

        public IActionResult Index()
        {
            var result = _popularCarService.GetAll();
            return View(result.Data);
        }
    }
}
