using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.DDD.Domain.Specification
{
    public interface ISpecification<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        bool IsSatisfiedBy(TAggregateRoot obj);
        Expression<Func<TAggregateRoot, bool>> ToExpression();
        ISpecification<TAggregateRoot> And(ISpecification<TAggregateRoot> specification);
        ISpecification<TAggregateRoot> And(Expression<Func<TAggregateRoot, bool>> predicate);
        ISpecification<TAggregateRoot> Or(ISpecification<TAggregateRoot> specification);
        ISpecification<TAggregateRoot> Or(Expression<Func<TAggregateRoot, bool>> predicate);
        ISpecification<TAggregateRoot> Not();
    }
}
