using Arinna.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail() { }

        public OrderDetail(int productId, decimal unitPrice, short quantity, float discount)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }

        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public short Quantity { get; private set; }
        public float Discount { get; private set; }
    }
}
