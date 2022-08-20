using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double result = SimpleMath.Add(num1, num2);
            Assert.AreEqual(num1 + num2, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method
            double num1 = 50;
            double num2 = 10;
            double result = SimpleMath.Multiply(num1, num2);
            Assert.AreEqual(result, num1 * num2);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            double a = 10;
            double b = 0;

            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(a, b));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod()]
        [DataRow(50, 10)]
        [DataRow(100, 10)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Divide_WithTwoValidNumbers_ReturnsAValidAnswer(double num1, double num2) 
        {
            if (num2 != 0)
            {
                double results = num1 / num2;
                Assert.AreEqual(num1 / num2, results);
            }
            else 
            {
                Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
            }
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(50, 10)]
        [DataRow(100, 10)]
        [DataRow(-1, -10)]
        [DataRow(100, -5)]
        public void Subtrack_WithTwoValidNumbers_ReturnsAValidAnswer(double num1, double num2)
        {
            double results = num1 - num2;
            Assert.AreEqual(results, num1 - num2);
        }
    }
}