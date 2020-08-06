using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arinna.Northwind.ProductService.Business.Contract;
using Arinna.Northwind.ProductService.Business.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arinna.Northwind.ProductService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager productManager;
        private readonly ICategoryManager categoryManager;
        private readonly ISupplierManager supplierManager;

        public ProductController(IProductManager productManager,ICategoryManager categoryManager,ISupplierManager supplierManager)
        {
            this.productManager = productManager;
            this.categoryManager = categoryManager;
            this.supplierManager = supplierManager;
        }

        [HttpGet("GetProduct")]
        public IEnumerable<ProductDto> GetProduct()
        {
            return productManager.GetAll();
        }

        [HttpGet("GetProduct/{id}")]
        public ProductDto GetProduct(int id)
        {
            return productManager.Get(id);
        }

        //// POST: api/Product
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Product/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
