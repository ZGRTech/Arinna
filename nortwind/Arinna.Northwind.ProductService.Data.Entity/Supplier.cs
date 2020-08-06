using Arinna.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Entity
{
    public class Supplier: Entity<int>
    {
        public Supplier()
        {
            ProductList = new HashSet<Product>();
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public virtual ICollection<Product> ProductList { get; set; }
    }
}
