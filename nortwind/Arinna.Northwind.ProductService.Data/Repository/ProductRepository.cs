using Arinna.Data.EntityFramework;
using Arinna.Northwind.ProductService.Data.Entity;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Repository
{
    public class ProductRepository : EntityFrameworkRepository<Product>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
