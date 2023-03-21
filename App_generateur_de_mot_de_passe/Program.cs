using App_Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_generateur_de_mot_de_passe
{
    class Program
    {
        enum e_choix
        {
            MINUS = 1,
            MINUS_MAJ = 2,
            MINUS_MAJ_CHIFF = 3,
            MINUS_MAJ_CHIFF_CARSPE = 4
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string chiffres = "0123456789";
            string caracteresSpeciaux = "/+*-@#$&";
            string majuscules = minuscules.ToUpper();
            string alphabet = "";
            string motDePasse = "";
            const int NB_MOT_DE_PASSE = 10;

            int longueurMotDePasse = Outils.DemanderNombrePositifNonNul("Entrez la longueur du mot de passe : ");
            Console.WriteLine();
            e_choix choix = (e_choix)Outils.DemanderNombreEntre("Vous voulez un mot de passe  avec :\n1 - Uniquement des caracteres en minuscule\n2 - Des caracteres minuscules et majuscules\n3 - Des caracteres et chiffres\n4 - Caracteres, chiffres et caracteres spéciaux\nVotre choix : ", 1, 4);

            switch (choix)
            {
                case e_choix.MINUS:
                    alphabet = minuscules;
                    break;
                case e_choix.MINUS_MAJ:
                    alphabet = minuscules + majuscules;
                    break;
                case e_choix.MINUS_MAJ_CHIFF:
                    alphabet = minuscules + majuscules + chiffres;
                    break;
                case e_choix.MINUS_MAJ_CHIFF_CARSPE:
                    alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
                    break;
            }
            int longueurAlphabet = alphabet.Length;
            int index;
            for(int j = 0; j < NB_MOT_DE_PASSE; j++)
            {
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];

                }
                Console.WriteLine("Mot de passe n° "+(j+1)+ " : " + motDePasse);
                motDePasse = "";
            }
            
            //Console.WriteLine("Longueur de mots de passe : " + motDePasse.Length);
            Console.ReadKey();
        }
    }
}
