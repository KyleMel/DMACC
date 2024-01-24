using Microsoft.AspNetCore.Mvc;
using MovieListMelton.Models;

namespace MovieListMelton.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context { get; set; }
        public MovieController(MovieContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add"; return View("Edit", new Movie());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit"; var movie = context.Movies.Find(id); return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                {
                    this.context.Movies.Add(movie);
                }
                else
                {
                    this.context.Update(movie);
                }
                this.context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit"; return View(movie);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
