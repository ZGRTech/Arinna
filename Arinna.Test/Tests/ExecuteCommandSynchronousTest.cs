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
    public class ExecuteCommandSynchronousTest
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

        //[TestMethod]
        //public void TestExecuteProductSqlCommandWithCommandText()
        //{
        //    const string obj = "AddedProductWithCommand";
        //    const int expected = 1;

        //    var command = $"Insert into dbo.Products Values ('{obj}',1,1,null,null)";
        //    var productService = new ProductService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    productService.ExecuteProductSqlCommand(command);
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlCommandWithCommandTextAndPredicate()
        //{
        //    const string objSource = "Product1";
        //    const string objTarget = "UpdatedProductWithCommand";
        //    const int expected = 1;

        //    var command = $"Update dbo.Products Set ProductName = '{objTarget}' where ProductName=@productName";
        //    var productService = new ProductService();
        //    var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
        //    productService.ExecuteProductSqlCommand(command, new SqlParameter("@productName", objSource));
        //    var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

        //    Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlCommandWithSqlCommand()
        //{
        //    const string obj = "AddedProductWithSqlCommand";
        //    const int expected = 1;

        //    var command = $"Insert into dbo.Products Values ('{obj}',1,1,null,null)";
        //    var sqlCommand = new SqlCommand(command);

        //    var productService = new ProductService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    productService.ExecuteProductSqlCommand(sqlCommand);
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlCommandWithSqlCommandAndPredicate()
        //{
        //    const string objSource = "Product2";
        //    const string objTarget = "UpdatedProductWithSqlCommand";
        //    const int expected = 1;

        //    var command = $"Update dbo.Products Set ProductName = '{objTarget}' where ProductName=@productName";
        //    var sqlCommand = new SqlCommand(command);
        //    sqlCommand.Parameters.AddWithValue("@productName", objSource);

        //    var productService = new ProductService();
        //    var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
        //    productService.ExecuteProductSqlCommand(sqlCommand);
        //    var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

        //    Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithCommandText()
        //{
        //    var productService = new ProductService();
        //    var datas = productService.ExecuteProductSqlQuery("select * from dbo.Products p");

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithCommandTextAndPredicate()
        //{
        //    var productService = new ProductService();
        //    var datas = productService.ExecuteProductSqlQuery("select * from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithSqlCommand()
        //{
        //    var productService = new ProductService();

        //    var sqlCommand = new SqlCommand("select * from dbo.Products p");

        //    var datas = productService.ExecuteProductSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithSqlCommandAndPredicate()
        //{
        //    var productService = new ProductService();

        //    var sqlCommand = new SqlCommand("select * from dbo.Products p where p.IsActive=@isActive");
        //    sqlCommand.Parameters.AddWithValue("@isActive", true);

        //    var datas = productService.ExecuteProductSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithCommandText()
        //{
        //    var productService = new ProductService();
        //    var datas = productService.ExecuteProductDtoSqlQuery("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithCommandTextAndPredicate()
        //{
        //    var productService = new ProductService();
        //    var datas = productService.ExecuteProductDtoSqlQuery("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithSqlCommand()
        //{
        //    var productService = new ProductService();

        //    var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

        //    var datas = productService.ExecuteProductDtoSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithSqlCommandAndPredicate()
        //{
        //    var productService = new ProductService();

        //    var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive");
        //    sqlCommand.Parameters.AddWithValue("@isActive", true);

        //    var datas = productService.ExecuteProductDtoSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}
    }
}
