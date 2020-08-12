using Arinna.Data.EntityFramework;
using Arinna.Northwind.OrderService.Domain.Aggregate.ShipperAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.OrderService.Infrastructure.DataAccess.Configuration
{
    public class ShipperConfiguration: EntityConfiguration<Shipper>
    {
        public ShipperConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Phone).HasMaxLength(24);
        }
    }
}
