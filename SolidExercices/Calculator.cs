using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private Dictionary<string, Func<string, decimal>> _operations = new Dictionary<string, Func<string, decimal>>() { {"+", addition}, {"-", soustraction}, {"*", multiplication}, {"/", division}};

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

        private static decimal addition(string operation)
        {
             try
            {
                decimal resultat = 0;
                string[] chiffres = operation.Split('+');
                foreach (string chiffre in chiffres)
                {
                    resultat += Convert.ToDecimal(chiffre);
                }
                return resultat;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
            }
            
        }

        private static decimal soustraction(string operation)
        {
             try
            {
                string[] chiffres = operation.Split('-');
                decimal resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                   resultat -= Convert.ToDecimal(chiffres[i]);
                }
            return resultat;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
            }
            
        }

        private static decimal multiplication(string operation)
        {
             try
            {
                string[] chiffres = operation.Split('*');
                decimal    resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                  resultat *= Convert.ToDecimal(chiffres[i]);
                }
                return resultat;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
            }
            
        }

        private static decimal division(string operation)
        {
             try
            {
                string[] chiffres = operation.Split('/');
                decimal resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat /= Convert.ToDecimal(chiffres[i]);
                }
                return resultat;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors du calcul : impossible d'effectuer le calcul. (Exception " + e + " )");
            }
            
        }
    }
}