using Microsoft.AspNetCore.Mvc;
using RiaanCarelse_ST10065550_POEPart1.Models;
using System.Diagnostics;

namespace RiaanCarelse_ST10065550_POEPart1.Controllers
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
            // Retrieve all products from the database
            List<productTable> products = productTable.GetAllProducts();

            // Retrieve userID from session
            int? userID = _httpContextAccessor.HttpContext.Session.GetInt32("UserID");

            // Pass products and userID to the view
            ViewData["Products"] = products;
            ViewData["UserID"] = userID;

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult MyWork()
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
