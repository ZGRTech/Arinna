using Arinna.Northwind.ProductService.Business.Contract;
using Arinna.Northwind.ProductService.Business.Entity;
using Arinna.Northwind.ProductService.Data.Entity;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arinna.Northwind.ProductService.Business
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var productList = productRepository.GetAll(x => !x.IsDeleted);
            var productDtoList = productList.Select(x => new ProductDto
            {
                ProductName = x.ProductName,
                SupplierId = x.SupplierId,
                CategoryId=x.CategoryId,
                QuantityPerUnit=x.QuantityPerUnit,
                UnitPrice=x.UnitPrice,
                UnitsInStock=x.UnitsInStock,
                UnitsOnOrder=x.UnitsOnOrder,
                ReorderLevel=x.ReorderLevel,
                Discontinued=x.Discontinued
            });
            return productDtoList;
        }

        public ProductDto Get(int id)
        {
            var product = productRepository.Get(x => !x.IsDeleted && x.Id==id);
            if (product == null) return null;

            var productDto = new ProductDto
            {
                ProductName = product.ProductName,
                SupplierId = product.SupplierId,
                CategoryId = product.CategoryId,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            };
            return productDto;
        }
    }
}
