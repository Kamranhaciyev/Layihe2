﻿using Microsoft.AspNetCore.Mvc;

namespace FinalLayihesi.Areas.Admin.Controllers
{

    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}