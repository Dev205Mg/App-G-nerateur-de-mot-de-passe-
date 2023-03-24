using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Outils
{
    static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            /* premiere possibilité:
            return DemanderNombreEntre(question, 1, int.MaxValue);
            */

            //deuxieme possibilité : 
            int nombre = DemanderNombre(question);
            if (nombre > 0)
            {
                // nombre supérieur a zero
                return nombre;
            }
            Console.WriteLine("ERREUR: Le nombre doit être supérieur a 0 ");
            Console.WriteLine();
            return DemanderNombrePositifNonNul(question);
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            // on utilisent la fonction DemanderNombre et on fait une condition

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // le nombre compris entre min et max
                return nombre;
            }
            Console.WriteLine($"ERREUR : Le nombre doit être compris entre {min} et {max}");
            Console.WriteLine();
            // on utilisent une fonction recursive c_a_d fonction qui appel elle même
            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombre(string question)
        {
            int response;
            while (true)
            {
                Console.Write(question);
                string input = Console.ReadLine();
                try
                {
                    response = int.Parse(input);
                    return response;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez retrer un nombre ");
                    Console.WriteLine();
                }
            }

        }
    }
}
