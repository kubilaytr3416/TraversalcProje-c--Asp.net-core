﻿using Microsoft.AspNetCore.Mvc;

namespace TRAVEL.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
