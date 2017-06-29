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
                    try 
                    {
                    return opeCourante.Value(operation);
                    }
                    catch (Exception e)
                    {
                            throw new ArgumentException("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
                    }
                }
            }
            return 0;
        }
    }
}