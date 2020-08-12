using Arinna.Data;
using Arinna.DDD.Domain;
using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Repository
{
    public interface IOrderRepository : IAggregateRepository<Order>
    {

    }
}
