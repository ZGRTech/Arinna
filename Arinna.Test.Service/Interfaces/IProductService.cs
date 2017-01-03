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

        Product GetProductAsync(Expression<Func<Product, bool>> predicates);
        Product GetProductAsync(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path);

        List<Product> GetAllProductsAsync();
        List<Product> GetAllProductsAsync(Expression<Func<Product, bool>> predicate);
        List<Product> GetAllProductsAsync(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>> path);

        int ProductCountAsync();
        int ProductCountAsync(Expression<Func<Product, bool>> predicate);

        bool ProductAnyAsync();
        bool ProductAnyAsync(Expression<Func<Product, bool>> predicate);

        void AddProductAsync(Product product);
        void AddProductRangeAsync(IEnumerable<Product> products);

        void UpdateProductAsync(Product product);
        void UpdateProductRangeAsync(IEnumerable<Product> products);

        void RemoveProductAsync(Product product);
        void RemoveProductRangeAsync(IEnumerable<Product> products);

        void RunCrudProductOperationAsync(Product product);
        void RunCrudProductOperationRangeAsync(IEnumerable<Product> products);

        void ExecuteProductSqlCommand(string sql, params object[] parameters);
        void ExecuteProductSqlCommand(IDbCommand sqlCommand);

        List<Product> ExecuteProductSqlQuery(string sql, params object[] parameters);
        List<Product> ExecuteProductSqlQuery(IDbCommand sqlCommand);

        List<ProductDto> ExecuteProductDtoSqlQuery(string sql, params object[] parameters);
        List<ProductDto> ExecuteProductDtoSqlQuery(IDbCommand sqlCommand);

        void ExecuteProductSqlCommandAsync(string sql, params object[] parameters);
        void ExecuteProductSqlCommandAsync(IDbCommand sqlCommand);

        List<Product> ExecuteProductSqlQueryAsync(string sql, params object[] parameters);
        List<Product> ExecuteProductSqlQueryAsync(IDbCommand sqlCommand);

        List<ProductDto> ExecuteProductDtoSqlQueryAsync(string sql, params object[] parameters);
        List<ProductDto> ExecuteProductDtoSqlQueryAsync(IDbCommand sqlCommand);


    }
}
