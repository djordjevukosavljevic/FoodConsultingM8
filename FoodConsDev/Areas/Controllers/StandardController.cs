using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    public class StandardController : Controller
    {

        private readonly StandardService standardService;
        

        public StandardController(StandardService standardService)
        {
            this.standardService = standardService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
    
    }
}
