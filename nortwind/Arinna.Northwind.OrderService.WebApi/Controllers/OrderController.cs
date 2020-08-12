using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arinna.Northwind.OrderService.Application.Contract;
using Arinna.Northwind.OrderService.Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Arinna.Northwind.OrderService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderAppService orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            this.orderAppService = orderAppService;
        }

        [HttpGet("GetShipper")]
        public IEnumerable<ShipperDto> GetShipper()
        {
            return orderAppService.GetAllActiveShipper();
        }

        [HttpPost("AddShipper")]
        public void Post([FromBody] ShipperAddDto shipper)
        {
            orderAppService.AddShipper(shipper);
        }

        [HttpPut("UpdateShipper")]
        public void Put([FromBody] ShipperUpdateDto shipper)
        {
            orderAppService.UpdateShipper(shipper);
        }

        [HttpDelete("DeleteShipper/{id}")]
        public void Delete(int shipperId)
        {
            orderAppService.DeleteShipper(shipperId);
        }
    }
}