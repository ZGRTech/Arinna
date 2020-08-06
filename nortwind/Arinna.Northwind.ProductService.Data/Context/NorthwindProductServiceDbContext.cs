using Arinna.Data.EntityFramework;
using Arinna.Northwind.ProductService.Data.Entity;
using Arinna.Northwind.ProductService.Data.Entity.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Context
{
    public class NorthwindProductServiceDbContext : BaseDbContext
    {
        public NorthwindProductServiceDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public NorthwindProductServiceDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("NorthwindConnection"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "Test"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                modelBuilder.AllEntitiesFromAssembly(assembly, "Arinna.Northwind.ProductService.Data.Entity");
                modelBuilder.ApplyAllConfigurationsFromAssembly(assembly, "Arinna.Northwind.ProductService.Data.Entity.Configuration");
            }
        }
    }
}
