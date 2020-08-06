using Arinna.Data;
using Arinna.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Entity.Configuration
{
    public class SupplierConfiguration: EntityConfiguration<Supplier>
    {
        public SupplierConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Address).HasMaxLength(60);
            builder.Property(x => x.City).HasMaxLength(15);
            builder.Property(x => x.ContactName).HasMaxLength(30);
            builder.Property(x => x.ContactTitle).HasMaxLength(30);
            builder.Property(x => x.Country).HasMaxLength(15);
            builder.Property(x => x.Fax).HasMaxLength(24);
            builder.Property(x => x.HomePage).HasColumnType("ntext");
            builder.Property(x => x.Phone).HasMaxLength(24);
            builder.Property(x => x.PostalCode).HasMaxLength(10);
            builder.Property(x => x.Region).HasMaxLength(15);
        }
    }
}
