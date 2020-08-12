using Arinna.Data;
using Arinna.DDD.Domain;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Repository
{
    public interface IShipperRepository: IAggregateRepository<Shipper>
    {
    }
}
