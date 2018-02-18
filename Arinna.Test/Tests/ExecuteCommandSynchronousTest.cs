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
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
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
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
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

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
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

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
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
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.ExecuteProductSqlQuery("select * from dbo.Products p");

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithCommandTextAndPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.ExecuteProductSqlQuery("select * from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithSqlCommand()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master

        //    var sqlCommand = new SqlCommand("select * from dbo.Products p");

        //    var datas = productService.ExecuteProductSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductSqlQueryWithSqlCommandAndPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master

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
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.ExecuteProductDtoSqlQuery("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithCommandTextAndPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.ExecuteProductDtoSqlQuery("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive", new SqlParameter("@isActive", true));

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithSqlCommand()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master

        //    var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p");

        //    var datas = productService.ExecuteProductDtoSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //}

        //[TestMethod]
        //public void TestExecuteProductDtoSqlQueryWithSqlCommandAndPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master

        //    var sqlCommand = new SqlCommand("select p.ProductId,p.ProductName,p.IsActive from dbo.Products p where p.IsActive=@isActive");
        //    sqlCommand.Parameters.AddWithValue("@isActive", true);

        //    var datas = productService.ExecuteProductDtoSqlQuery(sqlCommand);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //}
    }
}
