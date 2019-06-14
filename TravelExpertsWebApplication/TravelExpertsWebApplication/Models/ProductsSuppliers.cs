using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class ProductsSuppliers
    {
        public ProductsSuppliers()
        {
            BookingDetails = new HashSet<BookingDetails>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSuppliers>();
        }

        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }

        public Products Product { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<BookingDetails> BookingDetails { get; set; }
        public ICollection<PackagesProductsSuppliers> PackagesProductsSuppliers { get; set; }
    }
}
