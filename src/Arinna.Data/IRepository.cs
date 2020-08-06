using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] navigationPropertyPath);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] navigationPropertyPath);
        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);
        bool Any();
        bool Any(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity, bool softDelete = true);
        void DeleteRange(IEnumerable<TEntity> entities, bool softDelete = true);
    }
}
