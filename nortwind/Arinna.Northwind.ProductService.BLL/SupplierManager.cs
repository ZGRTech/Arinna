using Arinna.Northwind.ProductService.BLL.Contract;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.BLL
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
