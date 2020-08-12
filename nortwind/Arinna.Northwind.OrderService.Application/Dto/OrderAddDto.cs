using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderAddDto
    {
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}
