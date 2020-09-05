using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLiabrarary;
using NUnit.Framework;


namespace MathLiabrarary.Nunit.Tests
{
    [TestFixture]
   public class CalculatorTest
    {
        [Test]
        public void Add_Positive_testforNUnit()
        {
            int expectedResult = 20;
            Calculator c = new Calculator();
            int actualResult = c.Add(10, 10);


            Assert.AreEqual(expectedResult, actualResult);

            Console.WriteLine("Welcome");
        }


        [Test]
        public void Add_Negative_testforNUNit()
        {
            int expectedResult = 10;
            Calculator c = new Calculator();
            int actualResult = c.Add(10, 10);


            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
   