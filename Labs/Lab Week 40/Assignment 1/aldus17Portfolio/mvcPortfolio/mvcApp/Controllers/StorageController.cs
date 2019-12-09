using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcApp.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StorageInfo()
        {
            return View();
        }
    }
}