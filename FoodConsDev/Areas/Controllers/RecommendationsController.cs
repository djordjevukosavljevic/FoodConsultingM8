﻿using Microsoft.AspNetCore.Mvc;

namespace FoodConsDev.Areas.Controllers
{
    public class RecommendationsController : Controller
    {
        private readonly ILogger<RecommendationsController> _logger;

        public RecommendationsController(ILogger<RecommendationsController> logger) 
        {
            _logger = logger;
        }

        public IActionResult Index() 
        { 
            return View("Areas/Views/Recommendations/Index.cshtml");
        }
    }
}
