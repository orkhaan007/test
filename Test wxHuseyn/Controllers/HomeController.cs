﻿using Microsoft.AspNetCore.Mvc;

namespace Test_wxHuseyn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
