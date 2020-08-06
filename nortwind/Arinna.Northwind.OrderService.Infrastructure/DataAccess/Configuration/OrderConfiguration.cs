using Arinna.Data.EntityFramework;
using Arinna.Northwind.OrderService.Infrastructure.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Configuration
{
    public class OrderConfiguration: EntityConfiguration<Order>
    {
        public OrderConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CustomerId).HasMaxLength(5).IsFixedLength();
            builder.Property(x => x.Freight).HasColumnType("money").HasDefaultValueSql("((0))");
            builder.Property(x => x.OrderDate).HasColumnType("datetime");
            builder.Property(x => x.RequiredDate).HasColumnType("datetime");
            builder.Property(x => x.ShipAddress).HasMaxLength(60);
            builder.Property(x => x.ShipCity).HasMaxLength(15);
            builder.Property(x => x.ShipCountry).HasMaxLength(15);
            builder.Property(x => x.ShipName).HasMaxLength(40);
            builder.Property(x => x.ShipPostalCode).HasMaxLength(10);
            builder.Property(x => x.ShipRegion).HasMaxLength(15);
            builder.Property(x => x.ShippedDate).HasColumnType("datetime");
        }
    }
}
