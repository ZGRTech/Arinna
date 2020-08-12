using Arinna.Data;
using Arinna.Data.EntityFramework;
using Arinna.Northwind.OrderService.Application.Contract;
using Arinna.Northwind.OrderService.Domain.DomainService;
using Arinna.Northwind.OrderService.Domain.Repository;
using Arinna.Northwind.OrderService.Infrastructure.DataAccess.Context;
using Arinna.Northwind.OrderService.Infrastructure.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Application.DependencyInjection
{
    public class DependencyRegistration
    {
        public static void RegisterDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindOrderServiceDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("NorthwindConnection"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "Test")));
            services.AddScoped<BaseDbContext, NorthwindOrderServiceDbContext>();
            services.AddScoped(typeof(IRepository<>),typeof(EntityFrameworkRepository<>));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IShipperRepository, ShipperRepository>();
            services.AddScoped<OrderManager>();
            services.AddScoped<ShipperManager>();
            services.AddScoped<IOrderAppService, OrderAppService>();
        }
    }
}
