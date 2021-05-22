using BounteousApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BouteousTests
{
    [TestClass]
    public class UnitTest
    {
        public int erros = 0;
        List<int> listToCalculate = new();

        [TestMethod]
        public void GetMinMax_Tests()
        {
            // Arrange
            List<int> mock = new() { 1, 99 };
            // Act
            Calculator calc = new();
            (int min, int max) = calc.GetMinMaxValue(mock);
            // Assert
            Assert.AreEqual(1, min);
            Assert.AreEqual(99, max);
        }

        [TestMethod]
        public void ValuesValidation_Success_Tests()
        {
            // Arrange
            List<string> mock = new()
            {
                "1",
                "2",
                "3"
            };

            // Act
            Calculator calc = new();
            (int errosReturn, List<int> listCalculateReturn) = calc.ValuesValidation(mock, listToCalculate, erros);
            // Assert
            Assert.AreEqual(0, errosReturn);
            Assert.AreEqual(3, listCalculateReturn.Count);
        }

        [TestMethod]
        public void ValuesValidation_Full_Fail_Tests()
        {
            // Arrange
            List<string> mock = new()
            {
                "a",
                "b",
                "c"
            };

            // Act
            Calculator calc = new();
            (int errosReturn, List<int> listCalculateReturn) = calc.ValuesValidation(mock, listToCalculate, erros);
            // Assert
            Assert.AreEqual(3, errosReturn);
            Assert.AreEqual(0, listCalculateReturn.Count);
        }

        [TestMethod]
        public void ValuesValidation_Mix_Tests()
        {
            // Arrange
            List<string> mock = new()
            {
                "a",
                "99",
                "c"
            };

            // Act
            Calculator calc = new();
            (int errosReturn, List<int> listCalculateReturn) = calc.ValuesValidation(mock, listToCalculate, erros);
            // Assert
            Assert.AreEqual(2, errosReturn);
            Assert.AreEqual(1, listCalculateReturn.Count);
        }

        [TestMethod]
        public void Average_Tests()
        {
            // Arrange
            List<int> mock = new()
            {
                4,
                4,
                4,
                4
            };

            // Act
            Calculator calc = new();
            var result = calc.GetAverage(mock);
            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Median_Tests()
        {
            // Arrange
            List<int> mock = new()
            {
                4,
                4,
                4,
                4
            };

            // Act
            Calculator calc = new();
            var result = calc.GetMedian(mock);
            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Median_Different_Numebrs_Tests()
        {
            // Arrange
            List<int> mock = new()
            {
                1,
                2,
                3,
                4
            };

            // Act
            Calculator calc = new();
            var result = calc.GetMedian(mock);
            // Assert
            Assert.AreEqual(2.5, result);
        }
    }
}
