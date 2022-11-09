using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System;
using Entities.Concrete;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Entities.ViewModels;

namespace RentACarMVC.Controllers
{
    public class BrandController:Controller
    {
        public ActionResult Index()
        {
            Common obj = new Common();
            string temp = obj.GetData("https://localhost:44316/api/brands/getall");

            VMBrandList data = JsonConvert.DeserializeObject<VMBrandList>(temp);

            return View(data);
        }

    }

    
}
