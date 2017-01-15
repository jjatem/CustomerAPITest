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

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            customer result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
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
