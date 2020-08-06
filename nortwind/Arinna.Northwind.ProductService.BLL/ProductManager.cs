using Arinna.Northwind.ProductService.BLL.Contract;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.BLL
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void GetAllProduct()
        {
            productRepository.GetAll(x => !x.IsDeleted);
        }
    }
}
