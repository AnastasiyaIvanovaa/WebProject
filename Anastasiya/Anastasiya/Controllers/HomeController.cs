using Anastasiya.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Anastasiya.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test(int id)
        {
            List<TestViewModel> testViews = new List<TestViewModel>();

            TestViewModel testViewModel1 = new TestViewModel
            {
                Name = "Anastasiya Ivanova",
                Description = "I am a student in SoftUni."
            };
            TestViewModel testViewModel2 = new TestViewModel
            {
                Name = "Anastasiya Bisharova",
                Description = "My old name."
            };
            testViews.Add(testViewModel1);
            testViews.Add(testViewModel2);
            return View(testViews);
        }

        public IActionResult Info()
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