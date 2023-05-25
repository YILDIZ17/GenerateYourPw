using System;
using GenerateYourPw;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateYourPw
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;

            int longueurMdp = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            Console.WriteLine();
            int choixAlphabet = outils.DemanderNombreEntre("Que voulez-vous dans votre mot de passe ?" +
                "\n 1 - Uniquement des caractères en miniscule " +
                "\n 2 - Des caractères en miniscules et majuscules " +
                "\n 3 - Des caractères et des chiffres " +
                "\n 4 - Des caractères, chiffres et caractères spéciaux" +
                "Votre choix : ", 1, 4);

            string miniscules = "abcdefghijklmnopqrstuvwxyzåæø";
            string majuscules = miniscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "@#&+-";
            string alphabet = miniscules + majuscules + chiffres + caracteresSpeciaux;
            string motDePasse = "";
            Random random = new Random();
            Console.WriteLine();
            if (choixAlphabet == 1)
            {
                alphabet = miniscules;
            }
            else if(choixAlphabet == 2)
            {
                alphabet = miniscules + majuscules;
            }
            else if(choixAlphabet == 3)
            {
                alphabet = miniscules + majuscules + chiffres;
            }
            else
            {
                alphabet = miniscules + majuscules + chiffres + caracteresSpeciaux;
            }
            int longueurAlphabet = alphabet.Length;
            for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMdp; i++)
                {
                    int index = random.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }
                Console.WriteLine($"Mot de passe : {motDePasse}");
            }
            Console.WriteLine();
        }
    }
}
