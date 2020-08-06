using Arinna.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Context
{
    public class NorthwindOrderServiceDbContext : BaseDbContext
    {
        public NorthwindOrderServiceDbContext()
        {
        }

        public NorthwindOrderServiceDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                modelBuilder.AllEntitiesFromAssembly(assembly, "Arinna.Northwind.OrderService.Infrastructure.DataAccess.Entity");
                modelBuilder.ApplyAllConfigurationsFromAssembly(assembly, "Arinna.Northwind.OrderService.Infrastructure.DataAccess.Configuration");
            }
        }
    }
}
