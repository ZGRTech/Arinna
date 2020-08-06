using Arinna.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Entity
{
    public class Shipper: Entity<int>
    {
        public Shipper()
        {
            OrderList = new HashSet<Order>();
        }

        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> OrderList { get; set; }
    }
}
