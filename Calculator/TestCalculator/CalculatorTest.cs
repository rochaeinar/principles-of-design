using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;


namespace TestCalculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Addition_Success()
        {
            Number a = new Number(1);
            Number b = new Number(2);

            Calculator.Calculator calculator = new Calculator.Calculator();
            Number result = calculator.Addition(a, b);

            Assert.AreEqual(3, result.Value);
        }

        [TestMethod]
        public void Calculator_Subtraction_Success()
        {
            Number a = new Number(2);
            Number b = new Number(1);

            Calculator.Calculator calculator = new Calculator.Calculator();
            Number result = calculator.Subtraction(a, b);

            Assert.AreEqual(1, result.Value);
        }

        [TestMethod]
        public void Calculator_Multiplication_Success()
        {
            Number a = new Number(2);
            Number b = new Number(1);

            Calculator.Calculator calculator = new Calculator.Calculator();
            Number result = calculator.Multiplication(a, b);

            Assert.AreEqual(2, result.Value);
        }

        [TestMethod]
        public void Calculator_Division_Success()
        {
            Number a = new Number(10);
            Number b = new Number(2);

            Calculator.Calculator calculator = new Calculator.Calculator();
            Number result = calculator.Division(a, b);

            Assert.AreEqual(5, result.Value);
        }

        [TestMethod]
        public void Calculator_Division_By_Zero_Success()
        {
            Number a = new Number(10);
            Number b = new Number(0);

            Calculator.Calculator calculator = new Calculator.Calculator();
            Number result = calculator.Division(a, b);

            Assert.IsTrue(Double.IsInfinity(result.Value));
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void Calculator_Not_Implemented_Exception_Success()
        {
            OperatorFactory operatorFactory = new OperatorFactory();
            operatorFactory.getOperator(Operation.POW);
        }
    }
}
