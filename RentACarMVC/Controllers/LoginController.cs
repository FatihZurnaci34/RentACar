using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RentACarMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var pUser = context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

                if (pUser != null)
                {

                    return RedirectToAction("Index", "AnaSayfa");

                }

                else
                {
                    ViewBag.Message = "E-mail veya şifreniz yanlış";
                    return View();
                }
            }
        }
    }
}
