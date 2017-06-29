using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal resultat = 0;
            try
            {
                if (operation.Contains('+'))
                {
                    string[] chiffres = operation.Split('+');
                    foreach (string chiffre in chiffres)
                    {
                        resultat += Convert.ToDecimal(chiffre);
                    }
                }
                else if (operation.Contains('-'))
                {
                    string[] chiffres = operation.Split('-');
                    resultat = Convert.ToDecimal(chiffres[0]);
                    for (int i = 1; i < chiffres.Length; i++)
                    {
                        resultat -= Convert.ToDecimal(chiffres[i]);
                    }
                }
                else if (operation.Contains('*'))
                {
                    string[] chiffres = operation.Split('*');
                    resultat = Convert.ToDecimal(chiffres[0]);
                    for (int i = 1; i < chiffres.Length; i++)
                    {
                        resultat *= Convert.ToDecimal(chiffres[i]);
                    }
                }
                else if (operation.Contains('/'))
                {
                    string[] chiffres = operation.Split('/');
                    resultat = Convert.ToDecimal(chiffres[0]);
                    for (int i = 1; i < chiffres.Length; i++)
                    {
                        resultat /= Convert.ToDecimal(chiffres[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
            }
            return resultat;
        }
    }
}