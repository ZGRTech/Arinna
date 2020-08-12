using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderShipperSetDto
    {
        public int OrderId { get; set; }
        public int ShipperId { get; set; }
        public decimal Freight { get; set; }
    }
}
