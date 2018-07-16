using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;

namespace UnitTestEmployeeApp
{
    [TestClass]
    public class UnitTestFTOC
    {
        [TestMethod]
        public void TestFTOC()
        {
            // Arrange
            string fahrenheit = "212";
            double expectedValue = 100;
            double actualValue;
            // Act
            actualValue = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
