using Microsoft.AspNetCore.Mvc;

namespace LA.UI.Controllers
{
    public class ConceptsController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Hello from ViewBag";
            //ViewData["Message"] = "Hello from ViewData";

            TempData["Message"] = "Hello from Previuos request";
            return View();
        }

        public IActionResult NextPage() {
            string message = TempData["Message"].ToString();
            return View("NextPage", message);
        }
    }
}
