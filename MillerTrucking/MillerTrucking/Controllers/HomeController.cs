using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MillerTrucking.Models;

namespace MillerTrucking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindTrucks(SearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
