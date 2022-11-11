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
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Text;

namespace RentACarMVC.Controllers
{
    public class BrandController : Controller
    {
        public ActionResult Index()
        {
            Common obj = new Common();
            string temp = obj.GetData("https://localhost:44316/api/brands/getall");

            VMBrandList data = JsonConvert.DeserializeObject<VMBrandList>(temp);

            return View(data);
        }

        public ActionResult AddPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(VMBrandAdd brand)
        {

            Common obj = new Common();
            string temp = obj.PostData("https://localhost:44316/api/brands/add", brand);


            var input = JsonConvert.SerializeObject(brand, Newtonsoft.Json.Formatting.Indented);

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            WebRequest request = WebRequest.Create("https://localhost:44316/api/brands/add" + id);
            request.Method = "DELETE";

            WebResponse response = request.GetResponse();
            return View();
        }


    }
}
