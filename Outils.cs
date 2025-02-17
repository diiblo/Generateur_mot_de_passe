using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class Outils
    {
        public static int VerifNombrePositifNonNul(string question)
        {
            //while (true) //Autre Méthode pour vérifier si le nombre est positif ou non nul
            //{
            //    int reponse = DemanderNombre(question);
            //    if (reponse > 0)
            //    {
            //        return reponse;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Erreur : Désolé votre nombre est négatif ou nul. Merci de recommencer.\n");
            //    }
            //}

            return VerifIntervalleNombre(question, 1, int.MaxValue, "Le nombre doit être positif et non null");
        }
        public static int VerifIntervalleNombre(string question, int min, int max, string messageErreur = null)
        {
            while (true)
            {
                int reponse = DemanderNombre(question);
                if (reponse >= min && reponse <= max)
                {
                    return reponse;
                }
                else
                {
                    if (messageErreur != null)
                    {
                        Console.WriteLine(messageErreur);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Erreur : Désolé votre nombre est hors de l'intervalle {min} et {max}.\n");
                        Console.WriteLine();

                    }
                }
            }
        }
        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.WriteLine("\n---------");
                Console.WriteLine("Générateur de mot de passe");
                Console.WriteLine("---------\n");
                Console.Write(question);

                try
                {
                    int reponse = int.Parse(Console.ReadLine());
                    return reponse;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous avez entré une mauvaise réponse.\n");
                    Console.WriteLine();

                }

            }

        }

        public static void MotDePasse(string caracteres, int longueurMotdePasse, int nbrProposition)
        {
            Random rand = new Random();
            
            for (int i = 1; i <= nbrProposition; i++)
            {
                string motDePasse = "";
                for (int y = 1; y <= longueurMotdePasse; y++)
                {
                    int index = rand.Next(0, caracteres.Length);
                    motDePasse += caracteres[index];
                }

                Console.WriteLine($"\n{i}- Proposition : {motDePasse}");

            }
            
        }
    }
}
