using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{

    [Area("Administration")]
    [Route("/Administration/[action]")]    
    public class StandardController : Controller
    {
        private readonly IStandardService standardService;
        public StandardController(IStandardService standardService)
        {
            this.standardService = standardService;
        }
        public IActionResult Standards()
        {
            return View();
        }



    
    }
}
