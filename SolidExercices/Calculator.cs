using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            double resultat = 0;
            if (operation.Contains('+'))
            {
                string[] chiffres = operation.Split('+');
                foreach (string chiffre in chiffres)
                {
                    resultat += Convert.ToDouble(chiffre);
                }
            }
            else if (operation.Contains('-'))
            {
                string[] chiffres = operation.Split('-');
                resultat = Convert.ToDouble(chiffres[0]);
                for(int i = 1; i < chiffres.Length; i++)
                {
                    resultat -= Convert.ToDouble(chiffres[i]);
                }
            }
            else if (operation.Contains('*'))
            {
                string[] chiffres = operation.Split('*');
                resultat = Convert.ToDouble(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat *= Convert.ToDouble(chiffres[i]);
                }
            }
            else if (operation.Contains('/'))
            {
                string[] chiffres = operation.Split('/');
                resultat = Convert.ToDouble(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat /= Convert.ToDouble(chiffres[i]);
                }
            }
            return resultat;
        }
    }
}