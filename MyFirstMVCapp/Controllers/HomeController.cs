using Microsoft.AspNetCore.Mvc;
using MyFirstMVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCapp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {

            return RedirectToAction("ResultPage", new { begYear, endYear});

        }
        public IActionResult ResultPage(int begYear, int endYear)
        {
            Person example = new Person();
            return View(example.People(begYear, endYear));
        }
    }
}
