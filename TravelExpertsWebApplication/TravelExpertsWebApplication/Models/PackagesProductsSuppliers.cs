using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class PackagesProductsSuppliers
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }

        public Packages Package { get; set; }
        public ProductsSuppliers ProductSupplier { get; set; }
    }
}
