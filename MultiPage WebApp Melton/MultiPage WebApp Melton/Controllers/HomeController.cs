using Microsoft.AspNetCore.Mvc;
using MultiPage_WebApp_Melton.Models;
using System.Diagnostics;

namespace MultiPage_WebApp_Melton.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
