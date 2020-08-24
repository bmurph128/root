using Microsoft.VisualStudio.TestTools.UnitTesting;
using RootInsuranceKata.Data;
using RootInsuranceKata.Logic;
using RootInsuranceKataTest.Properties;
using System.Collections.Generic;

namespace RootInsuranceKataTest
{
    [TestClass]
    public class CustomerFileUploadServiceTest
    {
        [TestMethod]
        public void DidFileLoad()
        {
            string name = "";

            CustomerFileUploadService serviceTest = new CustomerFileUploadService();

            List<Driver> results = serviceTest.ReadFileTest(Resources.TestData);

            foreach (Driver entry in results)
            {
                if (entry.Name == "Dan")
                {
                    name = "Dan";
                }
            }

            Assert.AreEqual("Dan", name);
        }



        [TestMethod]
        public void IsLogicCorrect()
        {
            
            CustomerFileUploadService serviceTest = new CustomerFileUploadService();

            List<DriverDto> results = serviceTest.UploadFileTest(Resources.TestData);
            List<string> names = new List<string>();
            foreach(DriverDto driver in results)
            {
                names.Add(driver.Name);
            }

            List<string> testResults = new List<string>();

            testResults.Add("Bob");
            testResults.Add("Alex");
            testResults.Add("Dan");
            testResults.Add("John");

            CollectionAssert.AreEqual(testResults, names);
        }
    }
}
