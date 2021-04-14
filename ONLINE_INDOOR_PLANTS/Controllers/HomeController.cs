using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ONLINE_INDOOR_PLANTS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_INDOOR_PLANTS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Plants()
        {
            return View();
        }
        public IActionResult Fertilizer()
        {
            return View();
        }
        public IActionResult Seeds()
        {
            return View();
        }
        public IActionResult Sortby()
        {
            return View();
        }
        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Signin()
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
