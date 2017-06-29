using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Operations
    {
        public static decimal addition(string operation)
        {
                decimal resultat = 0;
                string[] chiffres = operation.Split('+');
                foreach (string chiffre in chiffres)
                {
                    resultat += Convert.ToDecimal(chiffre);
                }
                return resultat;
        }

        public static decimal soustraction(string operation)
        {
            
                string[] chiffres = operation.Split('-');
                decimal resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat -= Convert.ToDecimal(chiffres[i]);
                }
                return resultat;
            

        }

        public static decimal multiplication(string operation)
        {
            
                string[] chiffres = operation.Split('*');
                decimal resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat *= Convert.ToDecimal(chiffres[i]);
                }
                return resultat;
            

        }

        public static decimal division(string operation)
        {
            
                string[] chiffres = operation.Split('/');
                decimal resultat = Convert.ToDecimal(chiffres[0]);
                for (int i = 1; i < chiffres.Length; i++)
                {
                    resultat /= Convert.ToDecimal(chiffres[i]);
                }
                return resultat;
            

        }
    }
}
