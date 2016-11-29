using Marduk.Data.Interfaces;
using Marduk.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Marduk.Data.Repositories
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

    }
}
