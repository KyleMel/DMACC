using Microsoft.AspNetCore.Mvc;
using MovieListMelton.Models;
using System.Diagnostics;
using System.Linq;

namespace MovieListMelton.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
