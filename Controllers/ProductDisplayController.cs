using Microsoft.AspNetCore.Mvc;

namespace RiaanCarelse_ST10065550_POEPart1.Controllers
{
    public class ProductDisplayController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = ProductDisplayModel.SelectProducts();
            return View(products);
        }
    }
}
