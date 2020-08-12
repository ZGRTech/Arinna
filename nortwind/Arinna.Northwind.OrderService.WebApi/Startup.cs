using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arinna.Northwind.OrderService.Application.DependencyInjection;
using Arinna.Northwind.OrderService.Infrastructure.DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Arinna.Northwind.OrderService.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            DependencyRegistration.RegisterDependencies(services, Configuration);

            services.AddDbContext<NorthwindOrderServiceDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("NorthwindConnection"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "Test")));

            services.AddControllers();

            services.AddSwaggerGen(c => { });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
