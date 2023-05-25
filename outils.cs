using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateYourPw
{
    internal class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: le nombre doit être positif et non null.");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonalise = null)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if(messageErreurPersonalise == null)
            {
                Console.WriteLine($"ERREUR: le nombre doir être compris entre {min} et {max} ");
            }
            else
            {
                Console.WriteLine(messageErreurPersonalise);
            }
            

            return DemanderNombreEntre(question, min, max, messageErreurPersonalise);
        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR: vous devez entrer un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
