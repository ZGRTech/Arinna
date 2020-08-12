using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderShipDetailUpdateDto
    {
        public int OrderId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
