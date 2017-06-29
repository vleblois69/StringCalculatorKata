using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            string[] chiffres = operation.Split('+');
            double resultat = 0;
            foreach (string chiffre in chiffres)
            {
                resultat += Convert.ToDouble(chiffre);
            }
            return resultat;
        }
    }
}