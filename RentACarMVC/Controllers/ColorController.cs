using AutoMapper;
using Business.Abstract;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RentACarMVC.Controllers
{
    public class ColorController : Controller
    {
        IColorService _colorService;
        IMapper _mapper;

        public ColorController(IColorService colorService, IMapper mapper)
        {
            _colorService = colorService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var result = _colorService.GetAll();
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
        public IActionResult Add(VMColorAdd model)
        {
            var colorAdd = _mapper.Map<Color>(model);
            _colorService.Add(colorAdd);
            return RedirectToAction("Index", "Color");
        }
        
        public IActionResult UpdatePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(VMColorUpdate model)
        {
            var colorUpdate = _mapper.Map<Color>(model);
            _colorService.Update(colorUpdate);
            return RedirectToAction("Index", "Color");
        }

       
        
    }
}
