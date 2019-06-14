using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Regions
    {
        public Regions()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public string RegionId { get; set; }
        public string RegionName { get; set; }

        public ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
