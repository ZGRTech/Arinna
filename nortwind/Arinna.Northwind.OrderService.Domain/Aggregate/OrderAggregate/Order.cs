using Arinna.Data;
using Arinna.DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate
{
    public class Order : Entity<int>, IAggregateRoot
    {
        public Order() { }

        public Order(int id, string customerId, int employeeId, DateTime requiredDate)
        {
            Id = id;
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = DateTime.Now;
            RequiredDate = requiredDate;

            OrderDetailList = new HashSet<OrderDetail>();
        }

        public string CustomerId { get; private set; }
        public int? EmployeeId { get; private set; }
        public DateTime? OrderDate { get; private set; }
        public DateTime? RequiredDate { get; private set; }
        public DateTime? ShippedDate { get; private set; }
        public int? ShipperId { get; private set; }
        public decimal? Freight { get; private set; }

        public virtual ICollection<OrderDetail> OrderDetailList { get; private set; }
        public virtual OrderShipDetail OrderShipDetail { get; private set; }

        public Order UpdateShipDetail(OrderShipDetail orderShipDetail)
        {
            OrderShipDetail = orderShipDetail;
            return this;
        }

        public Order AddOrderDetail(OrderDetail orderDetail)
        {
            if (OrderDetailList.Select(x => x.ProductId).Contains(orderDetail.ProductId))
            {
                throw new Exception("Product");
            }

            OrderDetailList.Add(orderDetail);

            return this;
        }

        public Order RemoveOrderDetail(int productId)
        {
            if (!OrderDetailList.Select(x => x.ProductId).Contains(productId))
            {
                throw new Exception("Product");
            }

            OrderDetailList.Remove(OrderDetailList.First(x => x.ProductId == productId));

            return this;
        }

        internal Order SetShipper(int shipperId,decimal freight)
        {
            ShipperId = shipperId;
            Freight = freight;
            ShippedDate = DateTime.Now;
            return this;
        }




    }
}
