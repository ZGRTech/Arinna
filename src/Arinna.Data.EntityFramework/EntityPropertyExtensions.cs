using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    public static class EntityPropertyExtensions
    {
        public static object GetEntityPropertyValue<TEntity>(this DbContext context, TEntity entity, string propertyName)
        {
            return context.Entry(entity).Property(propertyName).CurrentValue;
        }

        public static void SetEntityPropertyValue<TEntity>(this DbContext context, TEntity entity, string propertyName, object value)
        {
            context.Entry(entity).Property(propertyName).CurrentValue = value;
        }

        public static object GetEntityPropertyValue(this EntityEntry entity, string propertyName)
        {
            return entity.Property(propertyName).CurrentValue;
        }

        public static void SetEntityPropertyValue(this EntityEntry entity, string propertyName, object value)
        {
            entity.Property(propertyName).CurrentValue = value;
        }
    }
}
