using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.DDD.Domain.Specification
{
    public class NotSpecification<TAggregateRoot> : Specification<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        private readonly ISpecification<TAggregateRoot> specification;

        public NotSpecification(ISpecification<TAggregateRoot> specification)
        {
            this.specification = specification ?? throw new ArgumentNullException(nameof(specification)); ;
        }

        private static Expression<Func<TAggregateRoot, bool>> Not(Expression<Func<TAggregateRoot, bool>> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            var notExpression = Expression.Not(predicate.Body);
            var lambda = Expression.Lambda<Func<TAggregateRoot, bool>>(notExpression, predicate.Parameters.Single());
            return lambda;
        }

        public override Expression<Func<TAggregateRoot, bool>> ToExpression()
        {
            return Not(specification.ToExpression());
        }
    }
}
