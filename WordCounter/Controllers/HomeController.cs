﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [Produces("text/html")]
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
