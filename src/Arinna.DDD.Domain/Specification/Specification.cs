using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.DDD.Domain.Specification
{
    public abstract class Specification<TAggregateRoot> : ISpecification<TAggregateRoot> where TAggregateRoot : IAggregateRoot, new()
    {
        private readonly Expression<Func<TAggregateRoot, bool>> expression;

        internal Specification() { }

        public Specification(Expression<Func<TAggregateRoot, bool>> expression)
        {
                this.expression = expression ?? throw new ArgumentNullException(nameof(expression)); ;
        }

        public bool IsSatisfiedBy(TAggregateRoot obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return expression.Compile()(obj);
        }

        public ISpecification<TAggregateRoot> And(ISpecification<TAggregateRoot> specification)
        {
            return new AndSpecification<TAggregateRoot>(this, specification);
        }

        public ISpecification<TAggregateRoot> And(Expression<Func<TAggregateRoot, bool>> predicate)
        {
            return new AndSpecification<TAggregateRoot>(this, new ExpressionSpecification<TAggregateRoot>(predicate));
        }

        public ISpecification<TAggregateRoot> Or(ISpecification<TAggregateRoot> specification)
        {
            return new OrSpecification<TAggregateRoot>(this, specification);
        }

        public ISpecification<TAggregateRoot> Or(Expression<Func<TAggregateRoot, bool>> predicate)
        {
            return new OrSpecification<TAggregateRoot>(this, new ExpressionSpecification<TAggregateRoot>(predicate));
        }

        public ISpecification<TAggregateRoot> Not()
        {
            return new NotSpecification<TAggregateRoot>(this);
        }

        public virtual Expression<Func<TAggregateRoot, bool>> ToExpression()
        {
            return expression;
        }
    }
}
