using Arinna.Data.EntityFramework;
using Arinna.Northwind.ProductService.Data.Entity;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Data.Repository
{
    public class SupplierRepository : EntityFrameworkRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
