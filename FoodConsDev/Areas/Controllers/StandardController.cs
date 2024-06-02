using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    public class StandardController : Controller
    {
        private readonly ILogger<StandardController> _logger;

        

        public StandardController(ILogger<StandardController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
