using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace dotnetcore_sessions.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        
    }
}
