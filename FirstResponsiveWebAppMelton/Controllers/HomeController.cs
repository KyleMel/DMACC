using FirstResponsiveWebAppMelton.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMelton.Controllers
{
    public class HomeController : Controller
    {
        // Constant to represent the default age and avoid using magic numbers
        private const int DefaultAge = 0;

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.Age = DefaultAge;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstReponsiveWebAppModel model)
        {
            // Check if the submitted model is valid and if so, set the ViewBag properties
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Name = "";
                ViewBag.Age = DefaultAge;
            }
            return View(model);
        }
    }
}
