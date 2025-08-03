using Microsoft.AspNetCore.Mvc;
using PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models;
using System.Diagnostics;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Controllers
{
    // The HomeController handles requests for the main pages of the app
    public class HomeController : Controller
    {
        // Dependency injection for logging information during application runtime
        private readonly ILogger<HomeController> _logger;

        // Constructor that receives a logger and assigns it to a private field
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for the home page (/Home/Index)
        public IActionResult Index()
        {
            // Returns the Index.cshtml view
            return View();
        }

        // Action method for the privacy policy page 
        public IActionResult Privacy()
        {
            // Returns the Privacy.cshtml view
            return View();
        }

        // Action method for error handling — shown when an error occurs
        // The ResponseCache attribute prevents caching of the error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Return the Error view and pass an ErrorViewModel
            // The RequestId helps identify which request caused the error
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
