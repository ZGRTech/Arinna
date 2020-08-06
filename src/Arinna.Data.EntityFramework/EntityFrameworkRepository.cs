using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    public class EntityFrameworkRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly BaseDbContext context;
        private DbSet<TEntity> dbSet;

        protected virtual DbSet<TEntity> DbSet
        {
            get
            {
                if (dbSet == null)
                {
                    dbSet = context.Set<TEntity>();
                }
                return dbSet;
            }
        }

        public EntityFrameworkRepository(BaseDbContext context)
        {
            this.context = context as BaseDbContext;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.SingleOrDefault(predicate);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] navigationPropertyPath)
        {
            var entity = DbSet.Where(predicate);
            foreach (var p in navigationPropertyPath)
            {
                entity.Include(p);
            }
            return entity.SingleOrDefault();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] navigationPropertyPath)
        {
            var entities = DbSet.Where(predicate);
            foreach (var p in navigationPropertyPath)
            {
                entities.Include(p);
            }
            return entities;
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Count(predicate);
        }

        public bool Any()
        {
            return DbSet.Any();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any()) return;

            DbSet.AddRange(entities);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            context.SaveChanges();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any()) return;

            DbSet.UpdateRange(entities);
            context.SaveChanges();
        }

        public void Delete(TEntity entity,bool softDelete=true)
        {
            if(softDelete && entity is IDeletableEntity)
            {
                context.SetEntityPropertyValue(entity, nameof(IDeletableEntity.IsDeleted), true);
            }
            else
            {
                DbSet.Remove(entity);
            }
            context.SaveChanges();
        }

        public void DeleteRange(IEnumerable<TEntity> entities, bool softDelete = true)
        {
            if (entities == null || !entities.Any()) return;

            if (softDelete && entities.First() is IDeletableEntity)
            {
                foreach (var entity in entities)
                {
                    context.SetEntityPropertyValue(entity, nameof(IDeletableEntity.IsDeleted), true);
                }
            }
            else
            {
                DbSet.RemoveRange(entities);
            }
            context.SaveChanges();
        }
    }
}
