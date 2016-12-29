using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arinna.Test.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arinna.Test.Tests
{
    [TestClass]
    public class ExecuteCommandAsynchronousTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            const string xmlSchemaPath = @"..\..\DummyData\DummyDataSchema.xsd";
            const string xmlSourcePath = @"..\..\DummyData\DummyDataSource.xml";
            var connectionString = ConfigurationManager.ConnectionStrings["ArinnaTestContext"].ToString();

            NDbUnit.Core.INDbUnitTest mySqlDatabase = new NDbUnit.Core.SqlClient.SqlDbUnitTest(connectionString);

            mySqlDatabase.ReadXmlSchema(xmlSchemaPath);
            mySqlDatabase.ReadXml(xmlSourcePath);

            mySqlDatabase.PerformDbOperation(NDbUnit.Core.DbOperationFlag.CleanInsertIdentity);
        }

        [TestMethod]
        public void TestExecuteProductSqlCommandAsyncWithCommandText()
        {
            const string obj = "AddedProductWithCommand";
            const int expected = 1;

            var command = $"Insert into dbo.Products Values ('{obj}',1,1,null,null)";
            var productService = new ProductService();
            var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
            productService.ExecuteProductSqlCommandAsync(command);
            var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

            Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        }

        [TestMethod]
        public void TestExecuteProductSqlCommandAsyncWithCommandTextAndPredicate()
        {
            const string objSource = "Product1";
            const string objTarget = "UpdatedProductWithCommand";
            const int expected = 1;

            var command = $"Update dbo.Products Set ProductName = '{objTarget}' where ProductName=@productName";
            var productService = new ProductService();
            var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
            var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
            productService.ExecuteProductSqlCommandAsync(command, new SqlParameter("@productName", objSource));
            var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
            var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

            Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        }

        [TestMethod]
        public void TestExecuteProductSqlCommandAsyncWithSqlCommand()
        {
            const string obj = "AddedProductWithSqlCommand";
            const int expected = 1;

            var command = $"Insert into dbo.Products Values ('{obj}',1,1,null,null)";
            var sqlCommand = new SqlCommand(command);

            var productService = new ProductService();
            var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
            productService.ExecuteProductSqlCommandAsync(sqlCommand);
            var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

            Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        }

        [TestMethod]
        public void TestExecuteProductSqlCommandAsyncWithSqlCommandAndPredicate()
        {
            const string objSource = "Product2";
            const string objTarget = "UpdatedProductWithSqlCommand";
            const int expected = 1;

            var command = $"Update dbo.Products Set ProductName = '{objTarget}' where ProductName=@productName";
            var sqlCommand = new SqlCommand(command);
            sqlCommand.Parameters.AddWithValue("@productName", objSource);

            var productService = new ProductService();
            var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
            var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
            productService.ExecuteProductSqlCommandAsync(sqlCommand);
            var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
            var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

            Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        }

        [TestMethod]
        public void TestExecuteProductSqlQueryAsyncWithCommandText()
        {
            var productService = new ProductService();
            var datas = productService.ExecuteProductSqlQueryAsync("select * from dbo.Products p");

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
        }

        [TestMethod]
        public void TestExecuteProductSqlQueryAsyncWithCommandTextAndPredicate()
        {
            var productService = new ProductService();
            var datas = productService.ExecuteProductSqlQueryAsync("select * from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
            Assert.IsFalse(datas.Any(x => !x.IsActive));
        }

        [TestMethod]
        public void TestExecuteProductSqlQueryAsyncWithSqlCommand()
        {
            var productService = new ProductService();

            var sqlCommand = new SqlCommand("select * from dbo.Products p");

            var datas = productService.ExecuteProductSqlQueryAsync(sqlCommand);

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
        }

        [TestMethod]
        public void TestExecuteProductSqlQueryAsyncWithSqlCommandAndPredicate()
        {
            var productService = new ProductService();

            var sqlCommand = new SqlCommand("select * from dbo.Products p where p.IsActive=@isActive");
            sqlCommand.Parameters.AddWithValue("@isActive", true);

            var datas = productService.ExecuteProductSqlQueryAsync(sqlCommand);

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
            Assert.IsFalse(datas.Any(x => !x.IsActive));
        }

        [TestMethod]
        public void TestExecuteProductDtoSqlQueryAsyncWithCommandText()
        {
            var productService = new ProductService();
            var datas = productService.ExecuteProductDtoSqlQueryAsync("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
        }

        [TestMethod]
        public void TestExecuteProductDtoSqlQueryAsyncWithCommandTextAndPredicate()
        {
            var productService = new ProductService();
            var datas = productService.ExecuteProductDtoSqlQueryAsync("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
            Assert.IsFalse(datas.Any(x => !x.IsActive));
        }

        [TestMethod]
        public void TestExecuteProductDtoSqlQueryAsyncWithSqlCommand()
        {
            var productService = new ProductService();

            var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

            var datas = productService.ExecuteProductDtoSqlQueryAsync(sqlCommand);

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
        }

        [TestMethod]
        public void TestExecuteProductDtoSqlQueryAsyncWithSqlCommandAndPredicate()
        {
            var productService = new ProductService();

            var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive");
            sqlCommand.Parameters.AddWithValue("@isActive", true);

            var datas = productService.ExecuteProductDtoSqlQueryAsync(sqlCommand);

            Assert.IsNotNull(datas);
            Assert.IsTrue(datas.Any());
            Assert.IsFalse(datas.Any(x => !x.IsActive));
        }
    }
}
