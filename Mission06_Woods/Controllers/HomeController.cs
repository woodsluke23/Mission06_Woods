// using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Mission06_Woods.Models;
using System.Diagnostics;


namespace Mission06_Woods.Controllers
{
    public class HomeController : Controller
    {
        private Mission07Context _context;

        public HomeController(Mission07Context temp)
        {
            _context = temp; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            ViewBag.Movies = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Movies = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Form", new Movie());
        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            if (ModelState.IsValid)
            {

                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation");

            }
            else
            {
              ViewBag.Movies = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

                return View(response);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Movies = _context.Categories
             .OrderBy(x => x.CategoryName)
             .ToList();

            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
