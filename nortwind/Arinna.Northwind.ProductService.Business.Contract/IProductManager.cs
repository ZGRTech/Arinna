using Arinna.Northwind.ProductService.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Business.Contract
{
    public interface IProductManager
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto Get(int id);
    }
}
