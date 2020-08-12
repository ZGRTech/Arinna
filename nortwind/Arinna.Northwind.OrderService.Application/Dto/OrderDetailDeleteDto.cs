using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Dto
{
    [Serializable]
    public class OrderDetailDeleteDto
    {
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
    }
}
