using Anastasiya.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anastasiya.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel loginInputModel)
        {
            return Redirect("/");
        }
    }
}
