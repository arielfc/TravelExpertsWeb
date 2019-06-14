using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelExpertsWebApplication.Models;

namespace TravelExpertsWebApplication.Models
{
    public class CombinedModels
    {
        public IEnumerable<BookingDetails> bookingDetails { get; set; }
        public Customers customer { get; set; }
    }
}