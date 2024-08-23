
using FoodConsluting.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    [Route("/Administration/[controller]/[action]/{id}")]
    public class UserController : Controller{
        private readonly IUserService userService;
    }
}