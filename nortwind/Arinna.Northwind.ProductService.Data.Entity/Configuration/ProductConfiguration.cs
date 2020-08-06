using Arinna.Data;
using Arinna.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Entity.Configuration
{
    public class ProductConfiguration: EntityConfiguration<Product>
    {
        public ProductConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.QuantityPerUnit).HasMaxLength(20);
            builder.Property(x => x.ReorderLevel).HasDefaultValueSql("((0))");
            builder.Property(x => x.UnitPrice).HasColumnType("money").HasDefaultValueSql("((0))");
            builder.Property(x => x.UnitsInStock).HasDefaultValueSql("((0))");
            builder.Property(x => x.UnitsOnOrder).HasDefaultValueSql("((0))");
        }
    }
}
