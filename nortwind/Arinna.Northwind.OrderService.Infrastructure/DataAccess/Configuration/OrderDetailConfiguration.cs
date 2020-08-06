using Arinna.Data.EntityFramework;
using Arinna.Northwind.OrderService.Infrastructure.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Configuration
{
    public class OrderDetailConfiguration : EntityConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.Property(x => x.Quantity).HasDefaultValueSql("((1))");
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
