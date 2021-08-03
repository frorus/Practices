using NUnit.Framework;
using System;

namespace Practices.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Multiplication(300, 10) == 3000);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Division(300, 10) == 30);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
