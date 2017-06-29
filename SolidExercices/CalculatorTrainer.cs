using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private static readonly OperationsGenerator _generator;
        private readonly string[] _operations = _generator.Generate();

        public void Run()
        {
            var calculator = new Calculator();
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }
}
