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
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4,5-1,5");
            Check.That(result).IsEqualTo(3.0);
        }
    }
}
