using Arinna.Data;
using Arinna.Data.EntityFramework;
using Arinna.DDD.Domain;
using Arinna.DDD.Domain.Specification;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using Arinna.Northwind.OrderService.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Repository
{
    public class ShipperRepository : IShipperRepository
    {
        private readonly IRepository<Shipper> genericShipperRepository;

        public ShipperRepository(IRepository<Shipper> genericShipperRepository)
        {
            this.genericShipperRepository = genericShipperRepository;
        }

        public Shipper Get(ISpecification<Shipper> specification)
        {
            return genericShipperRepository.Get(specification.ToExpression());
        }

        public IEnumerable<Shipper> GetAll()
        {
            return genericShipperRepository.GetAll();
        }

        public IEnumerable<Shipper> GetAll(ISpecification<Shipper> specification)
        {
            return genericShipperRepository.GetAll(specification.ToExpression());
        }

        public int Count()
        {
            return genericShipperRepository.Count();
        }

        public int Count(ISpecification<Shipper> specification)
        {
            return genericShipperRepository.Count(specification.ToExpression());
        }

        public bool Any()
        {
            return genericShipperRepository.Any();
        }

        public bool Any(ISpecification<Shipper> specification)
        {
            return genericShipperRepository.Any(specification.ToExpression());
        }

        public void Add(Shipper entity)
        {
            genericShipperRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Shipper> entities)
        {
            genericShipperRepository.AddRange(entities);
        }

        public void Update(Shipper entity)
        {
            genericShipperRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Shipper> entities)
        {
            genericShipperRepository.UpdateRange(entities);
        }

        public void Delete(Shipper entity)
        {
            genericShipperRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Shipper> entities)
        {
            genericShipperRepository.DeleteRange(entities);
        }
    }
}
