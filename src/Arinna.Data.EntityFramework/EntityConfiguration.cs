using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    public abstract class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly string schemaName;
        private readonly string tableName;

        public EntityConfiguration()
        {
        }

        public EntityConfiguration(string schemaName)
        {
            this.schemaName = schemaName;
        }

        public EntityConfiguration(string tableName, string schemaName)
        {
            this.tableName = tableName;
            this.schemaName = schemaName;
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (string.IsNullOrEmpty(tableName) && string.IsNullOrEmpty(schemaName))
            {
                builder.ToTable(typeof(TEntity).Name);
            }
            else if(string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(schemaName))
            {
                builder.ToTable(typeof(TEntity).Name, schemaName);
            }
            else
            {
                builder.ToTable(tableName, schemaName);
            }

            if(typeof(TEntity).GetInterfaces().Contains(typeof(IAuditableEntity)))
            {
                builder.Property(nameof(IAuditableEntity.CreatedDate)).IsRequired(false);
                builder.Property(nameof(IAuditableEntity.CreatedBy)).IsRequired(false).HasMaxLength(20);
                builder.Property(nameof(IAuditableEntity.UpdatedDate)).IsRequired(false);
                builder.Property(nameof(IAuditableEntity.UpdatedBy)).IsRequired(false).HasMaxLength(20);
            }
            if (typeof(TEntity).GetInterfaces().Contains(typeof(IDeletableEntity)))
            {
                builder.Property(nameof(IDeletableEntity.IsDeleted)).IsRequired(true);
            }
        }
    }
}
