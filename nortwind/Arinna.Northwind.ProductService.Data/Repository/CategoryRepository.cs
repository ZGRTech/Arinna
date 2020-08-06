using Arinna.Data.EntityFramework;
using Arinna.Northwind.ProductService.Data.Entity;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Repository
{
    public class CategoryRepository : EntityFrameworkRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
