using Arinna.Data.Model;
using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class, IBaseEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);

        bool Any();
        bool Any(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void RunCrudOperation(TEntity entity);
        void RunCrudOperationRange(IEnumerable<TEntity> entities);

        void ExecuteSqlCommand(string sql, object[] parameters);
        void ExecuteSqlCommand(IDbCommand sqlCommand);

        IEnumerable<TEntity> ExecuteSqlQuery(string sql, params object[] parameters);
        IEnumerable<TEntity> ExecuteSqlQuery(IDbCommand sqlCommand);
    }
}
