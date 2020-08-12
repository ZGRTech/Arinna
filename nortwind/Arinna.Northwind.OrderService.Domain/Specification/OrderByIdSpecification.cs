using Arinna.DDD.Domain;
using Arinna.DDD.Domain.Specification;
using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Domain.Specification
{
    public class OrderByIdSpecification : Specification<Order>
    {
        public OrderByIdSpecification(int id) : base(x => x.Id == id) { }
    }
}
