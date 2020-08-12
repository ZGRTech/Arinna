using Arinna.DDD.Domain;
using Arinna.DDD.Domain.Specification;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Specification
{
    public class ActiveShipperSpecification : Specification<Shipper>
    {
        public ActiveShipperSpecification() : base(x => !x.IsDeleted) { }
    }
}
