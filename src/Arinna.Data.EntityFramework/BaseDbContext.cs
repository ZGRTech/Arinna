using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Arinna.Data.EntityFramework
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext() { }

        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
              .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    var identityName = Thread.CurrentPrincipal?.Identity?.Name;
                    var now = DateTime.Now;
                    if (entry.State == EntityState.Added)
                    {
                        entry.SetEntityPropertyValue(nameof(IAuditableEntity.CreatedBy), identityName);
                        entry.SetEntityPropertyValue(nameof(IAuditableEntity.CreatedDate), now);
                    }
                    else
                    {
                        entry.Property(nameof(IAuditableEntity.CreatedBy)).IsModified = false;
                        entry.Property(nameof(IAuditableEntity.CreatedDate)).IsModified = false;
                    }
                    entry.SetEntityPropertyValue(nameof(IAuditableEntity.UpdatedBy), identityName);
                    entry.SetEntityPropertyValue(nameof(IAuditableEntity.UpdatedDate), now);
                }
            }
            return base.SaveChanges();
        }
    }
}
