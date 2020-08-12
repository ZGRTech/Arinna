using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.DDD.Domain.Specification
{
    public class ExpressionSpecification<TAggregateRoot> : Specification<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        public ExpressionSpecification(Expression<Func<TAggregateRoot, bool>> expression) : base(expression) { }
    }
}
