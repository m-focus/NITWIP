﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFOWebCoreMaster.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}