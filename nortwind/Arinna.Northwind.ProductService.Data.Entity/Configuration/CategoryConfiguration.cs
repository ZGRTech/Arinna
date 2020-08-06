using Arinna.Data;
using Arinna.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Entity.Configuration
{
    public class CategoryConfiguration: EntityConfiguration<Category>
    {
        public CategoryConfiguration() : base("Test") { }

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Description).HasColumnType("ntext");
            builder.Property(x => x.Picture).HasColumnType("image");
        }
    }
}
