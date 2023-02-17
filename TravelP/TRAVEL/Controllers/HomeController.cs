using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TRAVEL.Models;

namespace TRAVEL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogError("Error Log Çağrıldı");
            _logger.LogInformation("Index Sayfası Çağrıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d= Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation("d + Privacy Sayfası Çağrıldı");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
