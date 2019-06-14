using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class TripTypes
    {
        public TripTypes()
        {
            Bookings = new HashSet<Bookings>();
        }

        public string TripTypeId { get; set; }
        public string Ttname { get; set; }

        public ICollection<Bookings> Bookings { get; set; }
    }
}
