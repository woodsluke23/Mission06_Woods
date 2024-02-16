using Microsoft.AspNetCore.Mvc;
using Mission06_Woods.Models;
using System.Diagnostics;

namespace Mission06_Woods.Controllers
{
    public class HomeController : Controller
    {
        private Mission06Context _context;

        public HomeController(Mission06Context temp)
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

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }
    }
}
