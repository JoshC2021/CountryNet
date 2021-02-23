using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WorldCountriesNet.Models;

namespace WorldCountriesNet.Controllers
{

    public class HomeController : Controller
    {
        IList<Country> countriesList = new List<Country>
        {
            new Country{Name = "USA", OfficialLanguage = "English", HelloWorld = "Hello", Description = "Best fries", PrimaryColors = new[] {"Red","White","Blue" } },

            new Country { Name = "Germany", OfficialLanguage = "German", HelloWorld = "Guten Tag", Description = "Best composers", PrimaryColors = new[] { "Black", "Red", "Gold" } },

            new Country { Name = "Italy", OfficialLanguage = "Italian", HelloWorld = "Ciao", Description = "Best pizza", PrimaryColors = new[] { "Green", "White", "Red" } },
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["countries"] = countriesList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string country)
        {
            TempData["country"] = country;
            return RedirectToAction("Details");
        }

        public IActionResult Description()
        {
            ViewData["countries"] = countriesList;
            return View();
        }
        public IActionResult Details()
        {
            ViewData["countries"] = countriesList;
            return View();
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
