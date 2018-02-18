using Arinna.Data.Interfaces;
using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Arinna.Data.Model.Interfaces;
using Arinna.Data.Model.Models;

namespace Arinna.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
    {
        private readonly DbContext _context;
        private IDbSet<TEntity> _dbSet;

        protected virtual IDbSet<TEntity> DbSet
        {
            get
            {
                if (_dbSet == null)
                {
                    _dbSet = _context.Set<TEntity>();
                }
                return _dbSet;
            }
        }

        public BaseRepository(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context can not be null.");
            _context = context;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).SingleOrDefault();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            return DbSet.AsNoTracking().Where(predicate).Include(path).SingleOrDefault();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsNoTracking();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            return DbSet.AsNoTracking().Where(predicate).Include(path);
        }

        public int Count()
        {
            return DbSet.AsNoTracking().Count();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Count(predicate);
        }

        public bool Any()
        {
            return DbSet.AsNoTracking().Any();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Any(predicate);
        }

        public IQueryable<TEntity> Include(IQueryable<TEntity> entities, Expression<Func<TEntity, object>> path)
        {
            return entities.Include(path);
        }

        public void Add(TEntity entity)
        {
            SetEntityState(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                SetEntityState(entity);
            }
        }

        public void Update(TEntity entity)
        {
            SetEntityState(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                SetEntityState(entity);
            }
        }

        public void Remove(TEntity entity)
        {
            SetEntityState(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                SetEntityState(entity);
            }
        }

        public void RunCrudOperation(TEntity entity)
        {
            SetEntityState(entity);
        }

        public void RunCrudOperationRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                SetEntityState(entity);
            }
        }

        public void ExecuteSqlCommand(string sql, object[] parameters)
        {
            _context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public void ExecuteSqlCommand(IDbCommand sqlCommand)
        {
            var ret = sqlCommand.Parameters.Count == 0 ? _context.Database.ExecuteSqlCommand(sqlCommand.CommandText) : _context.Database.ExecuteSqlCommand(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<TEntity>(sql, parameters);
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(IDbCommand sqlCommand)
        {
            return sqlCommand.Parameters.Count == 0 ? _context.Database.SqlQuery<TEntity>(sqlCommand.CommandText) : _context.Database.SqlQuery<TEntity>(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));

        }

        public IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(string sql, params object[] parameters) where TDtoEntity : class, new()
        {
            return _context.Database.SqlQuery<TDtoEntity>(sql, parameters);
        }

        public IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class, new()
        {
            return sqlCommand.Parameters.Count == 0 ? _context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText) : _context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));
        }

        private void SetEntityState(TEntity entity)
        {
            _context.Entry(entity).State = ChangeObjectStateToEntityState(entity.ObjectState);
        }

        private EntityState ChangeObjectStateToEntityState(ObjectState objectState)
        {
            EntityState entityState;
            switch (objectState)
            {
                case ObjectState.Added:
                    entityState = EntityState.Added;
                    break;
                case ObjectState.Modified:
                    entityState = EntityState.Modified;
                    break;
                case ObjectState.Deleted:
                    entityState = EntityState.Deleted;
                    break;
                default:
                    entityState = EntityState.Unchanged;
                    break;
            }
            return entityState;
        }

        private object[] ConvertDataParameterCollectionToArray(IDataParameterCollection collection)
        {
            object[] parameters = new object[collection.Count];
            for (int i = 0; i < collection.Count; i++)
            {
                DbParameter dbParameter = collection[i] as DbParameter;
                if (dbParameter != null)
                {
                    SqlParameter sqlParameter = new SqlParameter(dbParameter.ParameterName, dbParameter.Value);
                    parameters[i] = sqlParameter;
                }
            }
            return parameters;
        }
    }
}
