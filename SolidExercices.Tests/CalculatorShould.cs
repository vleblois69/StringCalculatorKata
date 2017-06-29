using System;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4,5-1,5");
            Check.That(result).IsEqualTo(3.0m);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2,2*3,2");
            Check.That(result).IsEqualTo(7.04m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6/3");
            Check.That(result).IsEqualTo(2m);
        }

        [Test]
        public void NotCalculateWithLetters()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("habd+kofjgk")).Throws<Exception>();
        }

        [Test]
        public void NotDivideByZero()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("5/0")).Throws<Exception>();
        }

        [Test]
        public void NotCalculateWithMultipleOperators()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("12*3+6-4")).Throws<Exception>();
        }
    }
}
