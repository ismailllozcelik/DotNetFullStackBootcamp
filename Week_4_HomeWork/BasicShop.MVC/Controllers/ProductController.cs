﻿using Microsoft.AspNetCore.Mvc;

namespace BasicShop.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
