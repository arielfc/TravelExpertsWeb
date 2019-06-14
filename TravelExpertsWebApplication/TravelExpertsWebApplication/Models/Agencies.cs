using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Agencies
    {
        public Agencies()
        {
            Agents = new HashSet<Agents>();
        }

        public int AgencyId { get; set; }
        public string AgncyAddress { get; set; }
        public string AgncyCity { get; set; }
        public string AgncyProv { get; set; }
        public string AgncyPostal { get; set; }
        public string AgncyCountry { get; set; }
        public string AgncyPhone { get; set; }
        public string AgncyFax { get; set; }

        public ICollection<Agents> Agents { get; set; }
    }
}
