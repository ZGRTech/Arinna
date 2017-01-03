using Arinna.Data.Model;
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
    public interface IRepository<TEntity> where TEntity : BaseModel
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

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        Task<bool> AnyAsync();
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

        void ExecuteSqlCommand(string sql, object[] parameters);
        void ExecuteSqlCommand(IDbCommand sqlCommand);

        IEnumerable<TEntity> ExecuteSqlQuery(string sql,params object[] parameters);
        IEnumerable<TEntity> ExecuteSqlQuery(IDbCommand sqlCommand);

        IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(string sql,params object[] parameters) where TDtoEntity : class;
        IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class;

        Task ExecuteSqlCommandAsync(string sql,params object[] parameters);
        Task ExecuteSqlCommandAsync(IDbCommand sqlCommand);

        Task<IEnumerable<TEntity>> ExecuteSqlQueryAsync(string sql,params object[] parameters);
        Task<IEnumerable<TEntity>> ExecuteSqlQueryAsync(IDbCommand sqlCommand);

        Task<IEnumerable<TDtoEntity>> ExecuteSqlQueryAsync<TDtoEntity>(string sql, params object[] parameters) where TDtoEntity : class;
        Task<IEnumerable<TDtoEntity>> ExecuteSqlQueryAsync<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class;

    }
}
