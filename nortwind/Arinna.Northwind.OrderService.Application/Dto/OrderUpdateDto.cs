using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderUpdateDto
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}
