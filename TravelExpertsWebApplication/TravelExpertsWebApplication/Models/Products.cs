using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductsSuppliers = new HashSet<ProductsSuppliers>();
        }

        public int ProductId { get; set; }
        public string ProdName { get; set; }

        public ICollection<ProductsSuppliers> ProductsSuppliers { get; set; }
    }
}
