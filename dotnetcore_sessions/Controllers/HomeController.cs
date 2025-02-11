using System.Diagnostics;
using dotnetcore_sessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_sessions.Controllers
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
            //int a = 90;
            //string name = "Test";
            //return View("Index",name);

            Student student = new Student();
            student.Id = 1;
            student.Name = "ABC";
            student.City = "Kolhapur";

            return View(student);
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
    }
}
