using Arinna.Northwind.OrderService.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.Contract
{
    public interface IOrderAppService
    {
        List<ShipperDto> GetAllActiveShipper();
        void AddShipper(ShipperAddDto shipperAddDto);
        void UpdateShipper(ShipperUpdateDto shipperUpdateDto);
        void DeleteShipper(int shipperId);
        void AddOrder(OrderAddDto orderAddDto);
        void UpdateOrder(OrderUpdateDto orderUpdateDto);
        void UpdateOrderShipDetail(OrderShipDetailUpdateDto orderShipDetailUpdateDto);
        void AddOrderDetail(OrderDetailAddDto orderDetailAddDto);
        void RemoveOrderDetail(OrderDetailDeleteDto orderDetailDeleteDto);
        void SetOrderShipper(OrderShipperSetDto orderShipperSetDto);

    }
}
