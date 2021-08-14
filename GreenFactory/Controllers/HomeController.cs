using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GreenFactory.Models;
using Microsoft.AspNetCore.Authorization;

namespace GreenFactory.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Header"] = "Home";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewData["Header"] = "About us";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Header"] = "Contact";
            return View();
        }

        public IActionResult Products()
        {
            ViewData["Header"] = "Contact";
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
