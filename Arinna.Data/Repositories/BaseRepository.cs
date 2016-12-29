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

namespace Arinna.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context can not be null.");
            Context = context;
            DbSet = context.Set<TEntity>();
        }


        //Context.Database.DynamicSqlQuery
        //Attach


        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            return DbSet.AsNoTracking().Where(predicate).Include(path).FirstOrDefault();
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


        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            return await DbSet.AsNoTracking().Where(predicate).Include(path).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            return await DbSet.AsNoTracking().Where(predicate).Include(path).ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await DbSet.AsNoTracking().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().CountAsync(predicate);
        }

        public async Task<bool> AnyAsync()
        {
            return await DbSet.AsNoTracking().AnyAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().AnyAsync(predicate);
        }


        public void ExecuteSqlCommand(string sql, object[] parameters)
        {
            Context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public void ExecuteSqlCommand(IDbCommand sqlCommand)
        {
            var ret = sqlCommand.Parameters.Count == 0 ? Context.Database.ExecuteSqlCommand(sqlCommand.CommandText) : Context.Database.ExecuteSqlCommand(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(string sql, params object[] parameters)
        {
            return Context.Database.SqlQuery<TEntity>(sql, parameters);
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(IDbCommand sqlCommand)
        {
            return sqlCommand.Parameters.Count == 0 ? Context.Database.SqlQuery<TEntity>(sqlCommand.CommandText) : Context.Database.SqlQuery<TEntity>(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));

        }

        public IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(string sql, params object[] parameters) where TDtoEntity : class
        {
            return Context.Database.SqlQuery<TDtoEntity>(sql, parameters);
        }

        public IEnumerable<TDtoEntity> ExecuteSqlQuery<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class
        {
            return sqlCommand.Parameters.Count == 0 ? Context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText) : Context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters));
        }


        public async void ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            await Context.Database.ExecuteSqlCommandAsync(sql, parameters);
        }

        public async void ExecuteSqlCommandAsync(IDbCommand sqlCommand)
        {
            var ret = await (sqlCommand.Parameters.Count == 0 ? Context.Database.ExecuteSqlCommandAsync(sqlCommand.CommandText) : Context.Database.ExecuteSqlCommandAsync(sqlCommand.CommandText, ConvertDataParameterCollectionToArray(sqlCommand.Parameters)));
        }

        public async Task<IEnumerable<TEntity>> ExecuteSqlQueryAsync(string sql, params object[] parameters)
        {
            return await Context.Database.SqlQuery<TEntity>(sql, parameters).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> ExecuteSqlQueryAsync(IDbCommand sqlCommand)
        {
            return await (sqlCommand.Parameters.Count == 0 ? Context.Database.SqlQuery<TEntity>(sqlCommand.CommandText).ToListAsync() : Context.Database.SqlQuery<TEntity>(sqlCommand.CommandText, sqlCommand.Parameters).ToListAsync());
        }

        public async Task<IEnumerable<TDtoEntity>> ExecuteSqlQueryAsync<TDtoEntity>(string sql, params object[] parameters) where TDtoEntity : class
        {
            return await Context.Database.SqlQuery<TDtoEntity>(sql, parameters).ToListAsync();
        }

        public async Task<IEnumerable<TDtoEntity>> ExecuteSqlQueryAsync<TDtoEntity>(IDbCommand sqlCommand) where TDtoEntity : class
        {
            return await (sqlCommand.Parameters.Count == 0 ? Context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText).ToListAsync() : Context.Database.SqlQuery<TDtoEntity>(sqlCommand.CommandText, sqlCommand.Parameters).ToListAsync());
        }


        private void SetEntityState(TEntity entity)
        {
            Context.Entry(entity).State = ChangeObjectStateToEntityState(entity.ObjectState);
        }

        private EntityState ChangeObjectStateToEntityState(ObjectState objectState)
        {
            var entityState = EntityState.Unchanged;
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
