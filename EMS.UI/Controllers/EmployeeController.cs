using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
