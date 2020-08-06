using Arinna.Data.EntityFramework;
using Arinna.Northwind.ProductService.Business.Contract;
using Arinna.Northwind.ProductService.Data.Context;
using Arinna.Northwind.ProductService.Data.Repository;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Business.DependencyInjection
{
    public class DependencyRegistration
    {
        public static void RegisterDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindProductServiceDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("NorthwindConnection"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "Test")));
            services.AddScoped<BaseDbContext, NorthwindProductServiceDbContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ISupplierManager, SupplierManager>();
        }
    }
}
