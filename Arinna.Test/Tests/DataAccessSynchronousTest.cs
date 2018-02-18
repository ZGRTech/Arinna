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
      
    }
}
