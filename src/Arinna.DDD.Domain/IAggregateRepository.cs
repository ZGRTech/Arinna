using Arinna.DDD.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.DDD.Domain
{
    public interface IAggregateRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        TAggregateRoot Get(ISpecification<TAggregateRoot> specification);
        IEnumerable<TAggregateRoot> GetAll();
        IEnumerable<TAggregateRoot> GetAll(ISpecification<TAggregateRoot> specification);
        int Count();
        int Count(ISpecification<TAggregateRoot> specification);
        bool Any();
        bool Any(ISpecification<TAggregateRoot> specification);
        void Add(TAggregateRoot aggregateRoot);
        void AddRange(IEnumerable<TAggregateRoot> aggregateRoots);
        void Update(TAggregateRoot aggregateRoot);
        void UpdateRange(IEnumerable<TAggregateRoot> aggregateRoots);
        void Delete(TAggregateRoot aggregateRoot);
        void DeleteRange(IEnumerable<TAggregateRoot> aggregateRoots);
    }
}
