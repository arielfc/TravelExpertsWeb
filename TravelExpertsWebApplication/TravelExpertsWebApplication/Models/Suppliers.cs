using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            ProductsSuppliers = new HashSet<ProductsSuppliers>();
            SupplierContacts = new HashSet<SupplierContacts>();
        }

        public int SupplierId { get; set; }
        public string SupName { get; set; }

        public ICollection<ProductsSuppliers> ProductsSuppliers { get; set; }
        public ICollection<SupplierContacts> SupplierContacts { get; set; }
    }
}
