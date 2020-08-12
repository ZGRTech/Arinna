using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class ShipperAddDto
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
