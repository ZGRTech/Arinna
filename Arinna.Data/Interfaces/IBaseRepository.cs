using Arinna.Data.Model;
using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);

        bool Any();
        bool Any(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> Include(IQueryable<TEntity> entities, Expression<Func<TEntity, object>> path);

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

        IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(string sql, params object[] parameters) where TDtoEntity : class, new();
        IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class, new();
    }
}
