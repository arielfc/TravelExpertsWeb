﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelExpertsWeb.Models;

namespace TravelExpertsWeb.Controllers
{
    public class BookingDetailsController : Controller
    {
        private readonly TravelExpertsDBContext _context;

        public BookingDetailsController(TravelExpertsDBContext context)
        {
            _context = context;
        }

        // GET: BookingDetails
        public async Task<IActionResult> Index(int? id)
        {
            //return View(await _context.BookingDetails.ToListAsync());
            // 20190610 Get current cutomer's bookings in detail
            // 20190610 Get current cutomer's bookings in detail
            var results = from c in _context.BookingDetails.Include(c => c.Fee)
                          join b in
                            from b in _context.Bookings
                            where b.CustomerId == id
                            select b
                          on c.BookingId equals b.BookingId
                          join f in _context.Fees
                          on c.FeeId equals f.FeeId
                          orderby c.TripStart
                          select c;
            ViewBag.id = id;
            return View(results);
        }

        // GET: BookingDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails
                .FirstOrDefaultAsync(m => m.BookingDetailId == id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            return View(bookingDetails);
        }

        // GET: BookingDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingDetailId,ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,BookingId,RegionId,ClassId,FeeId,ProductSupplierId")] BookingDetails bookingDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingDetails);
        }

        // GET: BookingDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails.FindAsync(id);
            if (bookingDetails == null)
            {
                return NotFound();
            }
            return View(bookingDetails);
        }

        // POST: BookingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingDetailId,ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,BookingId,RegionId,ClassId,FeeId,ProductSupplierId")] BookingDetails bookingDetails)
        {
            if (id != bookingDetails.BookingDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingDetailsExists(bookingDetails.BookingDetailId))
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
            return View(bookingDetails);
        }

        // GET: BookingDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails
                .FirstOrDefaultAsync(m => m.BookingDetailId == id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            return View(bookingDetails);
        }

        // POST: BookingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingDetails = await _context.BookingDetails.FindAsync(id);
            _context.BookingDetails.Remove(bookingDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingDetailsExists(int id)
        {
            return _context.BookingDetails.Any(e => e.BookingDetailId == id);
        }
    }
}
