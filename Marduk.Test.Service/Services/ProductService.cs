using Marduk.Test.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marduk.Test.Model;
using System.Linq.Expressions;
using Marduk.Test.Data;
using Marduk.Data.UnitOfWork;

namespace Marduk.Test.Service.Services
{
    public class ProductService : IProductService
    {
        public Product GetProduct(Expression<Func<Product, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Get(predicate);
            }
        }

        public Product GetProduct(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Get(predicate, path);
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().GetAll().ToList();
            }
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().GetAll(predicate).ToList();
            }
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().GetAll(predicate, path).ToList();
            }
        }

        public int ProductCount()
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Count();
            }
        }

        public int ProductCount(Expression<Func<Product, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Count(predicate);
            }
        }

        public bool ProductAny()
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Any();
            }
        }

        public bool ProductAny(Expression<Func<Product, bool>> predicate)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                return uof.GetRepository<Product>().Any(predicate);
            }
        }

        public void AddProduct(Product product)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().Add(product);
                uof.Complete();
            }
        }

        public void AddProductRange(IEnumerable<Product> products)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().AddRange(products);
                uof.Complete();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().Update(product);
                uof.Complete();
            }
        }

        public void UpdateProductRange(IEnumerable<Product> products)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().UpdateRange(products);
                uof.Complete();
            }
        }

        public void RemoveProduct(Product product)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().Remove(product);
                uof.Complete();
            }
        }

        public void RemoveProductRange(IEnumerable<Product> products)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().RemoveRange(products);
                uof.Complete();
            }
        }

        public void RunCrudProductOperation(Product product)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().RunCrudOperation(product);
                uof.Complete();
            }
        }

        public void RunCrudProductOperationRange(IEnumerable<Product> products)
        {
            using (var uof = new UnitOfWork(new MardukTestContext()))
            {
                uof.GetRepository<Product>().RunCrudOperationRange(products);
                uof.Complete();
            }
        }
    }
}
