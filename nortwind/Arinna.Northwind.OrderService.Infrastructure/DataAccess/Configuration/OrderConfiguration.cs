using Arinna.Data.EntityFramework;
using Arinna.Northwind.OrderService.Domain.Aggregate.OrderAggregate;
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
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipAddress).HasMaxLength(60).HasColumnName(nameof(OrderShipDetail.ShipAddress));
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipCity).HasMaxLength(15).HasColumnName(nameof(OrderShipDetail.ShipCity));
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipCountry).HasMaxLength(15).HasColumnName(nameof(OrderShipDetail.ShipCountry));
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipName).HasMaxLength(40).HasColumnName(nameof(OrderShipDetail.ShipName));
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipPostalCode).HasMaxLength(10).HasColumnName(nameof(OrderShipDetail.ShipPostalCode));
            builder.OwnsOne(x => x.OrderShipDetail).Property(x => x.ShipRegion).HasMaxLength(15).HasColumnName(nameof(OrderShipDetail.ShipRegion));
            builder.Property(x => x.ShippedDate).HasColumnType("datetime");
        }
    }
}
