using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
using Arinna.Northwind.OrderService.Domain.Repository;
using Arinna.Northwind.OrderService.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.DomainService
{
    public class OrderManager: DDD.Domain.DomainService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IShipperRepository shipperRepository;

        public OrderManager(IOrderRepository orderRepository,IShipperRepository shipperRepository)
        {
            this.orderRepository = orderRepository;
            this.shipperRepository = shipperRepository;
        }

        public Order SetShipper(int orderId,int shipperId,decimal freight)
        {
            var order = orderRepository.Get(new OrderByIdSpecification(orderId));
            var shipper = shipperRepository.Get(new ShipperByIdSpecification(shipperId).And(new ActiveShipperSpecification()));

            if (order == null) throw new Exception("Product");
            if (shipper == null) throw new Exception("Shipper");

            order.SetShipper(shipper.Id, freight);
            orderRepository.Update(order);

            return order;
        }
    }
}
