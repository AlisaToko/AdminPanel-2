﻿using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ManagersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
