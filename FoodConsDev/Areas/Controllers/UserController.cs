
using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    [Route("/Administration/[controller]/[action]/{id}")]
    public class UserController : Controller{

        // Dependency injection
        private readonly IUserService userService;
    
        public UserController(IUserService userService){
            this.userService = userService;
        }

        public IActionResult Index(){
            return View();            
        }
    }

}