using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelExpertsWeb.Models
{
    public class CBDModels
    {
        public IEnumerable<BookingDetails> bookingDetails { get; set; }
        public Customers customer { get; set; }
    }
}
