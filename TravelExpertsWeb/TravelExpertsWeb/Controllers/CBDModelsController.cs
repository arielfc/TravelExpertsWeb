using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelExpertsWeb.Models;

namespace TravelExpertsWeb.Controllers
{
    public class CBDModelsController : Controller
    {
        private readonly TravelExpertsDBContext _context;//TravelExpertsContext

        public CBDModelsController(TravelExpertsDBContext context)//TravelExpertsContext
        {
            _context = context;
        }

        public ActionResult Index(int? id)
        {
            CBDModels results = new CBDModels();
            //var temp = from c1 in _context.Customers
            //                    where c1.CustomerId == id
            //                    select c1;
            results.customer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            results.bookingDetails = from c in _context.BookingDetails.Include(c => c.Fee)
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

    }
}