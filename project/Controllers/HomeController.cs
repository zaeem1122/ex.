﻿using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult aboutus()
        {
            return View();
        }
    }
}
