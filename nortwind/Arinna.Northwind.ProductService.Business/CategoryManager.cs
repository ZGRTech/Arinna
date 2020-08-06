using Arinna.Northwind.ProductService.Business.Contract;
using Arinna.Northwind.ProductService.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Northwind.ProductService.Business
{
    public class CategoryManager: ICategoryManager
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }



    }
}
