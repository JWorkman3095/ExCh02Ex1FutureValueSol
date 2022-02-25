using Microsoft.AspNetCore.Mvc;
using FutureValueEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValueEx.Controllers {

    public class HomeController : Controller {
        [HttpGet]
        public IActionResult Index() {

            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model) {

            ViewBag.FV = model.CalculateFutureValue();
            return View(model);

        }
    }
}
