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

namespace TravelExpertsWebApplication.Controllers
{
    public class CustomersController : Controller
    {
        private readonly TravelExpertsContext _context;

        public CustomersController(TravelExpertsContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var travelExpertsContext = _context.Customers.Include(c => c.Agent);
            return View(await travelExpertsContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .Include(c => c.Agent)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustFirstName,CustLastName,CustAddress,CustCity,CustProv,CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,PasswordNotHashed,PasswordHashed,PasswordSalt,CustUserName")] Customers customers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customers);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("email", customers.CustEmail);
                HttpContext.Session.SetString("username", customers.CustFirstName);
                HttpContext.Session.SetString("userid", customers.CustomerId.ToString());
                return RedirectToAction("Index", "Home");
            }
            //ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);

            return RedirectToAction("Register", "Home");
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return View(customers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustFirstName,CustLastName,CustAddress,CustCity,CustProv,CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,AgentId,PasswordNotHashed,PasswordHashed,PasswordSalt,CustUserName")] Customers customers)
        {
            if (id != customers.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return View(customers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .Include(c => c.Agent)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

        // POST: Login 
        [HttpPost]
        public async Task<IActionResult> Login(string CustEmail, string PasswordNotHashed)
        {
            Customers customers = await _context.Customers.FirstOrDefaultAsync(c => c.CustEmail == CustEmail);
            if (customers == null || customers.PasswordNotHashed != PasswordNotHashed)
            {
                //ModelState.AddModelError(nameof(customers.PasswordNotHashed), "Incorrect password");
                ////return View();
                //return RedirectToAction("Login", "Home");
                ModelState.AddModelError("LogOnError", "The user name or password provided is incorrect.");
                return View("~/Views/Home/Login.cshtml");
            }

            HttpContext.Session.SetString("email", customers.CustEmail);
            HttpContext.Session.SetString("username", customers.CustFirstName);
            HttpContext.Session.SetString("userid", customers.CustomerId.ToString());
            return RedirectToAction("Packages", "Home");
        }

        // GET: Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("email");
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("userid");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(Customers customers)
        {

            if (ModelState.IsValid)
            {
                if (_context.Customers.Any(x => x.CustUserName == customers.CustUserName))
                {
                    ViewBag.Message = "User name already exist! Please change your user name.";
                    ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
                    return View(customers);
                }
                else
                {
                    _context.Add(customers);
                    await _context.SaveChangesAsync();
                    ModelState.Clear();
                    ViewBag.message = customers.CustUserName + " registered successfully!";
                    return View("Index", "Home");   // "~/Views/Home/Index.cshtml"
                }
            }
            ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId", customers.AgentId);
            return RedirectToAction("Index", "Home");
        }
    }
}
