using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewDashboard model = new ViewDashboard();
            return View(model);
        }
    }
}
