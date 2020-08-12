using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    public class ShipperUpdateDto
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
