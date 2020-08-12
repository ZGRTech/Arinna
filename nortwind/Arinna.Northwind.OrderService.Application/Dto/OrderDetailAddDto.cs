using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderDetailAddDto
    {
        public int OrderId { get; set; }
        public List<OrderDetailDto> OrderDetailList { get; set; }

        [Serializable]
        public class OrderDetailDto
        {
            public int ProductId { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }
        }
    }
}
