using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "add";
            double num1 = 2.0;
            double num2 = 3.0;
            double expected = num1 + num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAddMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "add";
            double num1 = -3.0;
            double num2 = -4.0;
            double expected = num1 + num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "sub";
            double num1 = 3.0;
            double num2 = 2.0;
            double expected = num1 - num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "sub";
            double num1 = -2.0;
            double num2 = -1.0;
            double expected = num1 - num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "mul";
            double num1 = 4.0;
            double num2 = 3.0;
            double expected = num1 * num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "mul";
            double num1 = -2.0;
            double num2 = -3.0;
            double expected = num1 * num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "div";
            double num1 = 3.0;
            double num2 = 2.0;
            double expected = num1 / num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string str = "div";
            double num1 = -4.0;
            double num2 = -2.0;
            double expected = num1 / num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAddMethodWithOnePositiveNumber()
        {
            Calculator calculator = new Calculator();
            string str = "add";
            double num1 = 3.0;
            double num2 = -2.0;
            double expected = num1 + num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSubtractMethodWithOnePositiveNumber()
        {
            Calculator calculator = new Calculator();
            string str = "sub";
            double num1 = 4.0;
            double num2 = -2.0;
            double expected = num1 - num2;
            double result = calculator.DoOperation(num1, num2, str);
            Assert.AreEqual(expected, result);
        }
    }
}