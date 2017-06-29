using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private Dictionary<string, Func<string, decimal>> _operations = new Dictionary<string, Func<string, decimal>>() { {"+", Operations.addition}, {"-", Operations.soustraction}, {"*", Operations.multiplication}, {"/", Operations.division}};

        public decimal Calculate(string operation)
        {
            foreach(var opeCourante in _operations)
            {
                if (operation.Contains(opeCourante.Key))
                {
                    return opeCourante.Value(operation);
                }
            }
            return 0;
        }
    }
}