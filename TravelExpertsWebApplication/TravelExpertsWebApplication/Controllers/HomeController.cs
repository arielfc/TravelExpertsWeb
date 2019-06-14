using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelExpertsWebApplication.Models;
using TravelExpertsWebApplication.Controllers;
using Microsoft.AspNetCore.Http;

namespace TravelExpertsWebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly TravelExpertsContext _context;
        public HomeController(TravelExpertsContext context)
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


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> Account()
        {
            //int id = Convert.ToInt32(HttpContext.Session.GetString("userid"));


            //var bookings = await _context.Bookings.Include(b => b.Package)
            //    .Where(m => m.CustomerId == id).ToListAsync();
            //if (bookings == null)
            //{
            //    return NotFound();
            //}

            //return View(bookings);
            int id = Convert.ToInt32(HttpContext.Session.GetString("userid"));


            var bookings = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Package)
                .Where(m => m.CustomerId == id).ToListAsync();
            if (bookings == null)
            {
                return NotFound();
            }

            return View(bookings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
