using Arinna.DDD.Domain;
using Arinna.DDD.Domain.Specification;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Specification
{
    public class ShipperByIdSpecification : Specification<Shipper>
    {
        public ShipperByIdSpecification(int id) : base(x => x.Id == id) { }
    }
}
