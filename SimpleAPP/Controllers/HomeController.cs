using Microsoft.AspNetCore.Mvc;
using SimpleAPP.Models;
using System.Diagnostics;

namespace SimpleAPP.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [ActionName("Test")]
        [HttpGet]
        public string Test(Student student)
        {
            return ("hello"+student.Name+" \n Student Id "+student.StudentID);
        }
    }
}