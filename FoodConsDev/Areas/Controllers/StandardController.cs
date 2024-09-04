using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    [Route("/[controller]/[action]/{id}")]
    public class StandardController : Controller
    {
        //private readonly ILogger logger;
        private readonly StandardService standardService;


        public StandardController(StandardService standardService)
        {
            // this.logger = logger;
            this.standardService = standardService;
        }

        public IActionResult Index()
        {
            var resultFromDb = standardService.GetAll();
            return View(resultFromDb);
        }
    
    
    }
}
