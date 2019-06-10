using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelExpertsWeb.Models;
using TravelExpertsWeb.Controllers;

namespace TravelExpertsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly TravelExpertsDBContext _context;
        public HomeController(TravelExpertsDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> Packages()
        {
            return View(await _context.Packages.ToListAsync());
        }

        public IActionResult Blog()
        {
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            return View(await _context.Agencies.ToListAsync());
        }

        public IActionResult Account()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
