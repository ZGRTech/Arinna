using Arinna.Test.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Service.Interfaces
{
    public interface IProductService
    {
        Product GetProduct(Expression<Func<Product, bool>> predicate);
        Product GetProduct(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path);

        List<Product> GetAllProducts();
        List<Product> GetAllProducts(Expression<Func<Product, bool>> predicate);
        List<Product> GetAllProducts(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path);

        int ProductCount();
        int ProductCount(Expression<Func<Product, bool>> predicate);

        bool ProductAny();
        bool ProductAny(Expression<Func<Product, bool>> predicate);

        List<Product> IncludeProductRange(IQueryable<Product> products, Expression<Func<Product, object>> path);

        void AddProduct(Product product);
        void AddProductRange(IEnumerable<Product> products);

        void UpdateProduct(Product product);
        void UpdateProductRange(IEnumerable<Product> products);

        void RemoveProduct(Product product);
        void RemoveProductRange(IEnumerable<Product> products);

        void RunCrudProductOperation(Product product);
        void RunCrudProductOperationRange(IEnumerable<Product> products);

        void ExecuteProductSqlCommand(string sql, params object[] parameters);
        void ExecuteProductSqlCommand(IDbCommand sqlCommand);

        List<Product> ExecuteProductSqlQuery(string sql, params object[] parameters);
        List<Product> ExecuteProductSqlQuery(IDbCommand sqlCommand);

        List<ProductDto> ExecuteProductDtoSqlQuery(string sql, params object[] parameters);
        List<ProductDto> ExecuteProductDtoSqlQuery(IDbCommand sqlCommand);
    }
}
