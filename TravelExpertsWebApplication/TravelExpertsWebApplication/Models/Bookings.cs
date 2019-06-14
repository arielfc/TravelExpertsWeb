using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Bookings
    {
        public Bookings()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingNo { get; set; }
        public double? TravelerCount { get; set; }
        public int? CustomerId { get; set; }
        public string TripTypeId { get; set; }
        public int? PackageId { get; set; }

        public Customers Customer { get; set; }
        public Packages Package { get; set; }
        public TripTypes TripType { get; set; }
        public ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
