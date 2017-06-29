using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private static IOperationsRepository _generator;
        private string[] _operations;
        private Calculator _calculator;

        public void Run(IOperationsRepository operationsRepository, Calculator calculator)
        {
            _generator = operationsRepository;
            _operations = _generator.Generate();
            _calculator = calculator;
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
