﻿using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}