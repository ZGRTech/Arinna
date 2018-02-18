using Arinna.Data.Interfaces;
using Arinna.Data.Model;
using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, IBaseEntity, new()
    {
        private readonly DbContext _context;

        public BaseService(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context can not be null.");
            _context = context;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Get(predicate);
            }
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Get(predicate, path);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().GetAll().ToList();
            }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().GetAll(predicate).ToList();
            }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> path)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().GetAll(predicate, path).ToList();
            }
        }

        public int Count()
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Count();
            }
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Count(predicate);
            }
        }

        public bool Any()
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Any();
            }
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().Any(predicate);
            }
        }

        public void Add(TEntity entity)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().Add(entity);
            }
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().AddRange(entities);
            }
        }

        public void Update(TEntity entity)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().Update(entity);
            }
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().UpdateRange(entities);
            }
        }

        public void Remove(TEntity entity)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().Remove(entity);
            }
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().RemoveRange(entities);
            }
        }

        public void RunCrudOperation(TEntity entity)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().RunCrudOperation(entity);
            }
        }

        public void RunCrudOperationRange(IEnumerable<TEntity> entities)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().RunCrudOperationRange(entities);
            }
        }

        public void ExecuteSqlCommand(string sql, object[] parameters)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().ExecuteSqlCommand(sql, parameters);
            }
        }

        public void ExecuteSqlCommand(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                uof.GetRepository<TEntity>().ExecuteSqlCommand(sqlCommand);
            }
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(string sql, params object[] parameters)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().ExecuteSqlQuery(sql, parameters);
            }
        }

        public IEnumerable<TEntity> ExecuteSqlQuery(IDbCommand sqlCommand)
        {
            using (var uof = new UnitOfWork.UnitOfWork(_context))
            {
                return uof.GetRepository<TEntity>().ExecuteSqlQuery(sqlCommand);
            }

        }
    }
}
