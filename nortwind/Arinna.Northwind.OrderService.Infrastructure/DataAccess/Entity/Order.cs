using Arinna.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Entity
{
    public class Order: Entity<int>
    {
        public Order()
        {
            OrderDetailList = new HashSet<OrderDetail>();
        }

        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipperId { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetailList { get; set; }
    }
}
