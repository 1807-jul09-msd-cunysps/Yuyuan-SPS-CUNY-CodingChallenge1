using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;

namespace UnitTestEmployeeApp
{
    [TestClass]
    public class UnitTestCTOF
    {
        [TestMethod]
        public void TestCTOF()
        {
            // Arrange
            string celcius = "100";
            double expectedValue = 212;
            double actualValue;
            // Act
            actualValue = TemperatureConverter.CelsiusToFahrenheit(celcius);
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
