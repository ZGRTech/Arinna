using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        private static MethodInfo GetGenericMethod(Type type, string methodName)
        {
            return type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy).Where(m => m.IsGenericMethod && m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault(); ;
        }

        private static IEnumerable<Type> GetAllTypeOfConfigNamespace(Assembly assembly, params string[] configNamespace)
        {
            var typeList = assembly.GetTypes().Where(c => c.IsClass && !c.IsAbstract);
            if (configNamespace != null && configNamespace.Any())
            {
                typeList = typeList.Where(c => configNamespace.Contains(c.Namespace));
            }
            return typeList;
        }

        public static void AllEntitiesFromAssembly(this ModelBuilder modelBuilder, Assembly assembly, params string[] configNamespace)
        {
            var entityMethod = GetGenericMethod(typeof(ModelBuilder), "Entity");
            var typeList = GetAllTypeOfConfigNamespace(assembly, configNamespace).Where(x => x.IsSubclassOf(typeof(BaseEntity)) && x.GetCustomAttribute(typeof(DbSetIgnoreAttribute)) == null);

            foreach (var type in typeList)
            {
                var entityTypeBuilder = entityMethod.MakeGenericMethod(type).Invoke(modelBuilder, new object[] { });
                Console.WriteLine("ModelBuilder Entity: " + type.Name);
            }
        }

        public static void ApplyAllConfigurationsFromAssembly(this ModelBuilder modelBuilder, Assembly assembly, params string[] configNamespace)
        {
            var applyConfigurationMethod = GetGenericMethod(typeof(ModelBuilder), "ApplyConfiguration");
            var typeList = GetAllTypeOfConfigNamespace(assembly, configNamespace).Where(x => x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(EntityConfiguration<>));

            foreach (var type in typeList)
            {
                var entityType = type.BaseType.GenericTypeArguments[0];
                if (entityType.GetCustomAttribute(typeof(DbSetIgnoreAttribute)) == null)
                {
                    var applyConcreteMethod = applyConfigurationMethod.MakeGenericMethod(entityType);
                    applyConcreteMethod.Invoke(modelBuilder, new object[] { Activator.CreateInstance(type) });
                    Console.WriteLine($"ModelBuilder Entity: {entityType.Name}, ApplyConfiguration: {type.Name}");
                }
            }
        }
    }
}
