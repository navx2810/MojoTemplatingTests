using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using MarketCarpenterCore.Ext.MojoTemplateEngine;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices]IEngine engine)
        {
            string val = engine.Compile("a.hbs").Render(new { name = "matt" });
            return Ok(val);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
