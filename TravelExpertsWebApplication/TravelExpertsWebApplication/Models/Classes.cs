using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Classes
    {
        public Classes()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDesc { get; set; }

        public ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
