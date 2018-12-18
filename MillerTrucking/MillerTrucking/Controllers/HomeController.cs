using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MillerTrucking.Models;
using MillerTrucking.Tasks;

namespace MillerTrucking.Controllers
{
    public class HomeController : Controller
    {
        private HomeTasks _homeTasks = new HomeTasks();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindTrucks(SearchModel searchModel)
        {
            return new JsonResult(_homeTasks.GetTrucks(searchModel));
        }
    }
}
