using Arinna.Data;
using Arinna.Data.EntityFramework;
using Arinna.DDD.Domain;
using Arinna.DDD.Domain.Specification;
using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
using Arinna.Northwind.OrderService.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IRepository<Order> genericOrderRepository;

        public OrderRepository(IRepository<Order> genericOrderRepository)
        {
            this.genericOrderRepository = genericOrderRepository;
        }

        public Order Get(ISpecification<Order> specification)
        {
            return genericOrderRepository.Get(specification.ToExpression(), x => x.OrderDetailList);
        }

        public IEnumerable<Order> GetAll()
        {
            return genericOrderRepository.GetAll(x => true, x => x.OrderDetailList);
        }

        public IEnumerable<Order> GetAll(ISpecification<Order> specification)
        {
            return genericOrderRepository.GetAll(specification.ToExpression(), x => x.OrderDetailList);
        }

        public int Count()
        {
            return genericOrderRepository.Count();
        }

        public int Count(ISpecification<Order> specification)
        {
            return genericOrderRepository.Count(specification.ToExpression());
        }

        public bool Any()
        {
            return genericOrderRepository.Any();
        }

        public bool Any(ISpecification<Order> specification)
        {
            return genericOrderRepository.Any(specification.ToExpression());
        }

        public void Add(Order entity)
        {
            genericOrderRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Order> entities)
        {
            genericOrderRepository.AddRange(entities);
        }

        public void Update(Order entity)
        {
            genericOrderRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Order> entities)
        {
            genericOrderRepository.UpdateRange(entities);
        }

        public void Delete(Order entity)
        {
            genericOrderRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Order> entities)
        {
            genericOrderRepository.DeleteRange(entities);
        }
    }
}
