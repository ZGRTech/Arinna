using Arinna.Data.Interfaces;
using Arinna.Data.Model;
using Arinna.Data.Model.Interfaces;
using Arinna.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context can not be null.");
            _context = context;

            // Buradan istediğiniz gibi EntityFramework'ü konfigure edebilirsiniz.
            //_dbContext.Configuration.LazyLoadingEnabled = false;
            //_dbContext.Configuration.ValidateOnSaveEnabled = false;
            //_dbContext.Configuration.ProxyCreationEnabled = false;
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity, new()
        {
            return new BaseRepository<TEntity>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        //public async Task<int> CompleteAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
