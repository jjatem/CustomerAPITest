using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerAPITest;
using CustomerAPITest.Controllers;

namespace CustomerAPITest.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            IEnumerable<customer> result = controller.Get();

            //Test count
            int count = result.Count();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(count, result.Count());
            Assert.AreEqual("Apple Inc.", result.ElementAt(0).customer_name);
            Assert.AreEqual("Google, Inc.", result.ElementAt(1).customer_name);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            //Test value
            customer testValue = new customer()
            {
                id = 5,
                customer_name = "Tesla Motors",
                city = "Palo Alto",
                region_state = "CA",
                date_added = DateTime.Parse("2017-01-15 18:02:58")
            };

            // Act
            customer result = controller.Get(5);

            testValue.date_added = result.date_added;

            // Assert
            Assert.AreEqual(testValue.customer_name, result.customer_name);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            customer NewCustomerTest = new customer()
            {
                customer_name = "Test Customer",
                city = "Test City",
                date_added = DateTime.Now,
                region_state = "GA"
            };

            // Act
            bool Result = controller.Post(NewCustomerTest);

            // Assert
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
