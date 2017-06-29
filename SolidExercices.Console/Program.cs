﻿namespace SolidExercices.Console
{
    public class Program
    {
        public static void Main()
        {
            var calculatorTrainer = new CalculatorTrainer();
            calculatorTrainer.Run(new GeneratedOperations(), new Calculator());
        }
    }
}
