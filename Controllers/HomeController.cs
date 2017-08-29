using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e190.Model;
using e190.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace e190.Controllers
{
    public class HomeController : Controller
    {
        private readonly PieContext context;

        public HomeController(PieContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var pies = context.Pies.ToList();
            return View(new IndexVm { Pies = pies });
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
            return View();
        }
    }
}
