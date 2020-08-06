using Arinna.Northwind.ProductService.Business.Contract;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Business
{
    public class SupplierManager: ISupplierManager
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierManager(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }
    }
}
