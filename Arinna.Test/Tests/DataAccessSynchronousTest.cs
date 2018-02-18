using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arinna.Test.Service.Services;
using System.Linq;
using Arinna.Test.Model;
using Arinna.Data.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace Arinna.Test.Tests
{
    [TestClass]
    public class DataAccessSynchronousTest
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

<<<<<<< HEAD
        [TestMethod]
        public void Test_get_student_with_pradicate_return_filtered_student()
        {
            const string obj = "StudentName1";
            const string expected = "StudentName1";

            var studentService = new StudentService();
            var data = studentService.Get(x => x.StudentName == obj);

            Assert.IsNotNull(data);
            Assert.IsTrue(data.StudentName == expected);
            //Assert.IsNull(data.);
        }
=======
        //[TestMethod]
        //public void TestGetProductWithPredicate()
        //{
        //    const string obj = "Product1";
        //    const string expected = "Product1";

        //    var productService = new StudentService();
        //    var data = productService.GetProduct(x => x.ProductName == obj);

        //    Assert.IsNotNull(data);
        //    Assert.IsTrue(data.ProductName == expected);
        //    Assert.IsNull(data.Category);
        //}
>>>>>>> origin/master

        //[TestMethod]
        //public void TestGetProductWithPredicateAndPath()
        //{
        //    const string obj = "Product1";
        //    const string expected = "Product1";

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var data = productService.GetProduct(x => x.ProductName == obj, x => x.Category);

        //    Assert.IsNotNull(data);
        //    Assert.IsTrue(data.ProductName == expected);
        //    Assert.IsNotNull(data.Category);
        //}

        //[TestMethod]
        //public void TestGetAllProducts()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.GetAllProducts();

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsNull(datas.First().Category);
        //}

        //[TestMethod]
        //public void TestGetAllProductsWithPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.GetAllProducts(x => x.IsActive);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //    Assert.IsNull(datas.First().Category);
        //}

        //[TestMethod]
        //public void TestGetAllProductsWithPredicateAndPath()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.GetAllProducts(x => x.IsActive, x => x.Category);

        //    Assert.IsNotNull(datas);
        //    Assert.IsTrue(datas.Any());
        //    Assert.IsFalse(datas.Any(x => !x.IsActive));
        //    Assert.IsNotNull(datas.First().Category);
        //}

        //[TestMethod]
        //public void TestProductCount()
        //{
        //    const int expected = 10;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var data = productService.ProductCount();

        //    Assert.AreEqual(data, expected);
        //}

        //[TestMethod]
        //public void TestProductCountWithPredicate()
        //{
        //    const int expected = 8;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var data = productService.ProductCount(x => x.IsActive);

        //    Assert.AreEqual(data, expected);
        //}

        //[TestMethod]
        //public void TestProductAny()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var data = productService.ProductAny();

        //    Assert.IsTrue(data);
        //}

        //[TestMethod]
        //public void TestProductAnyWithPredicate()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var data = productService.ProductAny(x => x.IsActive);

        //    Assert.IsTrue(data);
        //}

        //[TestMethod]
        //public void TestIncludeProduct()
        //{
<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var datas = productService.GetAllProducts();
        //    var datas2 = productService.IncludeProductRange(datas.AsQueryable(), x => x.Category);

        //    Assert.IsNull(datas.First().Category);
        //    Assert.IsNotNull(datas2.First().Category);
        //}

        //[TestMethod]
        //public void TestAddProduct()
        //{
        //    const string obj = "AddedProduct";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    productService.AddProduct(new Product
        //    {
        //        ProductName = obj,
        //        IsActive = true,
        //        CategoryId = 1,
<<<<<<< HEAD
        //        ObjectState = ObjectState.Added
=======
        //        ObjectState = EntityObjectState.Added
>>>>>>> origin/master
        //    });
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        //}

        //[TestMethod]
        //public void TestAddProductRange()
        //{
        //    const string obj = "AddedProductMulti";
        //    const int expected = 2;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    productService.AddProductRange(new List<Product> {
        //        new Product
        //        {
        //            ProductName = obj,
        //            IsActive = false,
        //            CategoryId = 1,
<<<<<<< HEAD
        //            ObjectState = ObjectState.Added
=======
        //            ObjectState = EntityObjectState.Added
>>>>>>> origin/master
        //        },
        //        new Product
        //        {
        //            ProductName = obj,
        //            IsActive = false,
        //            CategoryId = 1,
<<<<<<< HEAD
        //            ObjectState = ObjectState.Added
=======
        //            ObjectState = EntityObjectState.Added
>>>>>>> origin/master
        //        }
        //    });
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        //}

        //[TestMethod]
        //public void TestUpdateProduct()
        //{
        //    const string objSource = "Product1";
        //    const string objTarget = "UpdatedProduct";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
        //    var data = productService.GetProduct(x => x.ProductName == objSource);
        //    data.ProductName = objTarget;
<<<<<<< HEAD
        //    data.ObjectState = ObjectState.Modified;
=======
        //    data.ObjectState = EntityObjectState.Modified;
>>>>>>> origin/master
        //    productService.UpdateProduct(data);
        //    var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

        //    Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        //}

        //[TestMethod]
        //public void TestUpdateProductRange()
        //{
        //    const string objSource1 = "Product2";
        //    const string objSource2 = "Product3";
        //    const string objTarget = "UpdatedProductMulti";
        //    const int expected = 2;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource1 || x.ProductName == objSource2);
        //    var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
        //    var datas = productService.GetAllProducts(x => x.ProductName == objSource1 || x.ProductName == objSource2);
        //    datas.ForEach(x =>
        //    {
        //        x.ProductName = objTarget;
<<<<<<< HEAD
        //        x.ObjectState = ObjectState.Modified;
=======
        //        x.ObjectState = EntityObjectState.Modified;
>>>>>>> origin/master
        //    });
        //    productService.UpdateProductRange(datas);
        //    var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource1 || x.ProductName == objSource2);
        //    var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

        //    Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        //}

        //[TestMethod]
        //public void TestRemoveProduct()
        //{
        //    const string obj = "Product4";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
        //    var dataBefore = productService.ProductCount(x => x.ProductName == obj);
        //    var data = productService.GetProduct(x => x.ProductName == obj);
        //    data.ObjectState = ObjectState.Deleted;
=======
        //    var productService = new StudentService();
        //    var dataBefore = productService.ProductCount(x => x.ProductName == obj);
        //    var data = productService.GetProduct(x => x.ProductName == obj);
        //    data.ObjectState = EntityObjectState.Deleted;
>>>>>>> origin/master
        //    productService.RemoveProduct(data);
        //    var dataAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataBefore - dataAfter == expected);
        //}

        //[TestMethod]
        //public void TestRemoveProductRange()
        //{
        //    const string obj1 = "Product5";
        //    const string obj2 = "Product6";
        //    const int expected = 2;

<<<<<<< HEAD
        //    var productService = new ProductService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj1 || x.ProductName == obj2);
        //    var datas = productService.GetAllProducts(x => x.ProductName == obj1 || x.ProductName == obj2);
        //    datas.ForEach(x => x.ObjectState = ObjectState.Deleted);
=======
        //    var productService = new StudentService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj1 || x.ProductName == obj2);
        //    var datas = productService.GetAllProducts(x => x.ProductName == obj1 || x.ProductName == obj2);
        //    datas.ForEach(x => x.ObjectState = EntityObjectState.Deleted);
>>>>>>> origin/master
        //    productService.RemoveProductRange(datas);
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj1 || x.ProductName == obj2);

        //    Assert.IsTrue(dataCountBefore - dataCountAfter == expected);
        //}

        //[TestMethod]
        //public void TestRunCrudProductOperationForInsert()
        //{
        //    const string obj = "AddedProductWithRunCrud";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    productService.RunCrudProductOperation(new Product
        //    {
        //        ProductName = obj,
        //        IsActive = true,
        //        CategoryId = 1,
<<<<<<< HEAD
        //        ObjectState = ObjectState.Added
=======
        //        ObjectState = EntityObjectState.Added
>>>>>>> origin/master
        //    });
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountAfter - dataCountBefore == expected);
        //}

        //[TestMethod]
        //public void TestRunCrudProductOperationForUpdate()
        //{
        //    const string objSource = "Product7";
        //    const string objTarget = "UpdatedProductWithRunCrud";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataCountBeforeSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountBeforeTarget = productService.ProductCount(x => x.ProductName == objTarget);
        //    var data = productService.GetProduct(x => x.ProductName == objSource);
        //    data.ProductName = objTarget;
<<<<<<< HEAD
        //    data.ObjectState = ObjectState.Modified;
=======
        //    data.ObjectState = EntityObjectState.Modified;
>>>>>>> origin/master
        //    productService.RunCrudProductOperation(data);
        //    var dataCountAfterSource = productService.ProductCount(x => x.ProductName == objSource);
        //    var dataCountAfterTarget = productService.ProductCount(x => x.ProductName == objTarget);

        //    Assert.IsTrue(dataCountBeforeSource - dataCountAfterSource == expected && dataCountAfterTarget - dataCountBeforeTarget == expected);
        //}

        //[TestMethod]
        //public void TestRunCrudProductOperationForDelete()
        //{
        //    const string obj = "Product8";
        //    const int expected = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    var data = productService.GetProduct(x => x.ProductName == obj);
        //    data.ObjectState = ObjectState.Deleted;
=======
        //    var productService = new StudentService();
        //    var dataCountBefore = productService.ProductCount(x => x.ProductName == obj);
        //    var data = productService.GetProduct(x => x.ProductName == obj);
        //    data.ObjectState = EntityObjectState.Deleted;
>>>>>>> origin/master
        //    productService.RunCrudProductOperation(data);
        //    var dataCountAfter = productService.ProductCount(x => x.ProductName == obj);

        //    Assert.IsTrue(dataCountBefore - dataCountAfter == expected);
        //}

        //[TestMethod]
        //public void TestRunCrudProductOperationRange()
        //{
        //    const string objSource2 = "Product9";
        //    const string objSource3 = "Product10";
        //    const string objTarget1 = "AddedProductWithRunCrudRange";
        //    const string objTarget2 = "UpdatedProductWithRunCrudRange";
        //    const int expected1 = 1;
        //    const int expected2 = 1;
        //    const int expected3 = 1;

<<<<<<< HEAD
        //    var productService = new ProductService();
=======
        //    var productService = new StudentService();
>>>>>>> origin/master
        //    var dataList = new List<Product>();

        //    var dataCount1Before = productService.ProductCount(x => x.ProductName == objTarget1);
        //    dataList.Add(new Product
        //    {
        //        ProductName = objTarget1,
        //        IsActive = true,
        //        CategoryId = 1,
<<<<<<< HEAD
        //        ObjectState = ObjectState.Added
=======
        //        ObjectState = EntityObjectState.Added
>>>>>>> origin/master
        //    });

        //    var dataCount2BeforeSource = productService.ProductCount(x => x.ProductName == objSource2);
        //    var dataCount2BeforeTarget = productService.ProductCount(x => x.ProductName == objTarget2);
        //    var data2 = productService.GetProduct(x => x.ProductName == objSource2);
        //    data2.ProductName = objTarget2;
<<<<<<< HEAD
        //    data2.ObjectState = ObjectState.Modified;
=======
        //    data2.ObjectState = EntityObjectState.Modified;
>>>>>>> origin/master
        //    dataList.Add(data2);

        //    var dataCount3Before = productService.ProductCount(x => x.ProductName == objSource3);
        //    var data3 = productService.GetProduct(x => x.ProductName == objSource3);
<<<<<<< HEAD
        //    data3.ObjectState = ObjectState.Deleted;
=======
        //    data3.ObjectState = EntityObjectState.Deleted;
>>>>>>> origin/master
        //    dataList.Add(data3);

        //    productService.RunCrudProductOperationRange(dataList);

        //    var dataCount1After = productService.ProductCount(x => x.ProductName == objTarget1);

        //    var dataCount2AfterSource = productService.ProductCount(x => x.ProductName == objSource2);
        //    var dataCount2AfterTarget = productService.ProductCount(x => x.ProductName == objTarget2);

        //    var dataCount3After = productService.ProductCount(x => x.ProductName == objSource3);

        //    Assert.IsTrue(dataCount1After - dataCount1Before == expected1);
        //    Assert.IsTrue(dataCount2BeforeSource - dataCount2AfterSource == expected2 && dataCount2AfterTarget - dataCount2BeforeTarget == expected2);
        //    Assert.IsTrue(dataCount3Before - dataCount3After == expected3);
        //}
    }
}
