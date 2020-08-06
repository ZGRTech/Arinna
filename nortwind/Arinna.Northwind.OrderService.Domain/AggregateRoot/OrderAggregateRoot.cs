using Arinna.DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.AggregateRoot
{
    public class OrderAggregateRoot : IAggregateRoot
    {
        public OrderAggregateRoot(string customerId, int employeeId, DateTime requiredDate)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = DateTime.Now;
            RequiredDate = requiredDate;
        }


        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipperId { get; set; }

        public ShipDetailAggregate ShipDetailAggregate { get; set; }
        public List<OrderDetailAggregate> OrderDetailAggregateList { get; set; }

        public OrderAggregateRoot UpdateShipDetail(ShipDetailAggregate shipDetailAggregate)
        {
            ShipDetailAggregate = shipDetailAggregate;
            return this;
        }

        public OrderAggregateRoot AddShipper(int shipperId)
        {
            ShippedDate = DateTime.Now;
            ShipperId = shipperId;
            return this;
        }

        public OrderAggregateRoot UpdateShipper(int shipperId)
        {
            ShippedDate = DateTime.Now;
            ShipperId = shipperId;
            return this;
        }

        public OrderAggregateRoot AddOrderDetail(OrderDetailAggregate orderDetailAggregate)
        {
            if(OrderDetailAggregateList.Select(x=> x.ProductId).Contains(orderDetailAggregate.ProductId))
            {
                throw new Exception("Product");
            }

            OrderDetailAggregateList.Add(orderDetailAggregate);

            return this;
        }

        public OrderAggregateRoot RemoveOrderDetail(int productId)
        {
            if (!OrderDetailAggregateList.Select(x => x.ProductId).Contains(productId))
            {
                throw new Exception("Product");
            }

            OrderDetailAggregateList.Remove(OrderDetailAggregateList.First(x=>x.ProductId== productId));

            return this;
        }



    }
}
