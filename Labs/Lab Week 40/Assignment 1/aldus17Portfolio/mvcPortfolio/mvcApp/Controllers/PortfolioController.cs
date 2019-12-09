using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Description()
        {
            return View();
        }

        public IActionResult Experince()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}