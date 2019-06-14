using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelExpertsWebApplication.Models
{
    public partial class Packages
    {
        public Packages()
        {
            Bookings = new HashSet<Bookings>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSuppliers>();
        }

        public int PackageId { get; set; }
        public string PkgName { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? PkgStartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
        public string PkgImg { get; set; }

        public ICollection<Bookings> Bookings { get; set; }
        public ICollection<PackagesProductsSuppliers> PackagesProductsSuppliers { get; set; }
    }
}
