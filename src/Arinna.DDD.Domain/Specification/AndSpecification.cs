using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.DDD.Domain.Specification
{
    public class AndSpecification<TAggregateRoot> : Specification<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        private readonly ISpecification<TAggregateRoot> leftSpecification;
        private readonly ISpecification<TAggregateRoot> rightSpecification;

        public AndSpecification(ISpecification<TAggregateRoot> leftSpecification, ISpecification<TAggregateRoot> rightSpecification)
        {
            this.leftSpecification = leftSpecification ?? throw new ArgumentNullException(nameof(leftSpecification)); ;
            this.rightSpecification = rightSpecification ?? throw new ArgumentNullException(nameof(rightSpecification));
        }

        private static Expression<Func<TAggregateRoot, bool>> And(Expression<Func<TAggregateRoot, bool>> leftPredicate, Expression<Func<TAggregateRoot, bool>> rightPredicate)
        {
            if (leftPredicate == null)
            {
                throw new ArgumentNullException(nameof(leftPredicate));
            }

            if (rightPredicate == null)
            {
                throw new ArgumentNullException(nameof(rightPredicate));
            }

            var visitor = new SwapVisitor(leftPredicate.Parameters[0], rightPredicate.Parameters[0]);
            var binaryExpression = Expression.AndAlso(visitor.Visit(leftPredicate.Body), rightPredicate.Body);
            var lambda = Expression.Lambda<Func<TAggregateRoot, bool>>(binaryExpression, rightPredicate.Parameters);
            return lambda;
        }

        public override Expression<Func<TAggregateRoot, bool>> ToExpression()
        {
            return And(leftSpecification.ToExpression(), rightSpecification.ToExpression());
        }
    }
}
