using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLiabrarary;
namespace MathLiabrarary.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Positive_test()
        {
            int expectedResult = 20;
            Calculator c = new Calculator();
            int actualResult = c.Add(10, 10);


            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Add_Negative_test()
        {
            int expectedResult = 10;
            Calculator c = new Calculator();
            int actualResult = c.Add(10, 10);


            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}