using Microsoft.AspNetCore.Mvc;
using MyFirstASPWebApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPWebApp.controllers
{
    public class newController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult gradecalc ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult gradecalc (gradecalcmodel model) 
        {
            return View();
        }

    }
}
