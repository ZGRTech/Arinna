using Arinna.DDD.Application;
using Arinna.Northwind.OrderService.Application.Contract;
using Arinna.Northwind.OrderService.Application.Dto;
using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using Arinna.Northwind.OrderService.Domain.DomainService;
using Arinna.Northwind.OrderService.Domain.Repository;
using Arinna.Northwind.OrderService.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arinna.Northwind.OrderService.Application
{
    public class OrderAppService : ApplicationService, IOrderAppService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IShipperRepository shipperRepository;
        private readonly OrderManager orderManager;
        private readonly ShipperManager shipperManager;

        public OrderAppService(IOrderRepository orderRepository, IShipperRepository shipperRepository, OrderManager orderManager, ShipperManager shipperManager)
        {
            this.orderRepository = orderRepository;
            this.shipperRepository = shipperRepository;
            this.orderManager = orderManager;
            this.shipperManager = shipperManager;
        }

        public List<ShipperDto> GetAllActiveShipper()
        {
            var shipperList = shipperRepository.GetAll(new ActiveShipperSpecification());

            return shipperList.Select(x => new ShipperDto
            {
                CompanyName = x.CompanyName,
                Phone = x.Phone
            }).ToList();
        }

        public void AddShipper(ShipperAddDto shipperAddDto)
        {
            var shipper = new Shipper(0, shipperAddDto.CompanyName, shipperAddDto.Phone);
            shipperRepository.Add(shipper);
        }

        public void UpdateShipper(ShipperUpdateDto shipperUpdateDto)
        {
            var shipper = new Shipper(shipperUpdateDto.ShipperId, shipperUpdateDto.CompanyName, shipperUpdateDto.Phone);
            shipperRepository.Update(shipper);
        }

        public void DeleteShipper(int shipperId)
        {
            var shipper = shipperRepository.Get(new ShipperByIdSpecification(shipperId).And(new ActiveShipperSpecification()));

            if (shipper == null) throw new Exception("Shipper");

            shipperRepository.Delete(shipper);
        }

        public void AddOrder(OrderAddDto orderAddDto)
        {
            //Todo:Customer ve Employee Kendi Servislerinden Kontrol Edilecek
            var order = new Order(0, orderAddDto.CustomerId, orderAddDto.EmployeeId, orderAddDto.RequiredDate);
            orderRepository.Add(order);
        }

        public void UpdateOrder(OrderUpdateDto orderUpdateDto)
        {
            //Todo:Customer ve Employee Kendi Servislerinden Kontrol Edilecek
            var order = new Order(orderUpdateDto.OrderId, orderUpdateDto.CustomerId, orderUpdateDto.EmployeeId, orderUpdateDto.RequiredDate);
            orderRepository.Update(order);
        }

        public void UpdateOrderShipDetail(OrderShipDetailUpdateDto orderShipDetailUpdateDto)
        {
            var order = orderRepository.Get(new OrderByIdSpecification(orderShipDetailUpdateDto.OrderId));

            var orderShipDetail = new OrderShipDetail(orderShipDetailUpdateDto.ShipName, orderShipDetailUpdateDto.ShipAddress, orderShipDetailUpdateDto.ShipCity, orderShipDetailUpdateDto.ShipRegion, orderShipDetailUpdateDto.ShipPostalCode, orderShipDetailUpdateDto.ShipCountry);

            order.UpdateShipDetail(orderShipDetail);
            orderRepository.Update(order);
        }

        public void AddOrderDetail(OrderDetailAddDto orderDetailAddDto)
        {
            var order = orderRepository.Get(new OrderByIdSpecification(orderDetailAddDto.OrderId));

            orderDetailAddDto.OrderDetailList.ForEach(x =>
            {
                order.AddOrderDetail(new OrderDetail(x.ProductId, x.UnitPrice, x.Quantity, x.Discount));
            });

            orderRepository.Update(order);
        }

        public void RemoveOrderDetail(OrderDetailDeleteDto orderDetailDeleteDto)
        {
            var order = orderRepository.Get(new OrderByIdSpecification(orderDetailDeleteDto.OrderId));

            order.RemoveOrderDetail(orderDetailDeleteDto.ProductId);
            orderRepository.Update(order);
        }

        public void SetOrderShipper(OrderShipperSetDto orderShipperSetDto)
        {
            var order = orderManager.SetShipper(orderShipperSetDto.OrderId, orderShipperSetDto.ShipperId, orderShipperSetDto.Freight);

            orderRepository.Update(order);
        }

    }
}
