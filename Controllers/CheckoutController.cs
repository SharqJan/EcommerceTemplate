﻿using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
