﻿using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant() { Id = 1, Name = "My Pizza restaurant" };
            return new ObjectResult(model);
            //return Content("Hello from the HomeController :D");
        }
    }
}