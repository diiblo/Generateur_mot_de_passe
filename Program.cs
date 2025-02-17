using FormationCS;
namespace Generateur_mot_de_passe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const int NBR_PROPOSITIONS = 10;
            //1-Longueur du mot de passe
            int longueurMotdePasse = Outils.VerifNombrePositifNonNul("Quelle est la longueur du mot de passe voulu : ");


            //2-Type de mot de passe

            int choixType = Outils.VerifIntervalleNombre("Quel type de mot de passe voulez-vous ?\n" +
                "1- Uniquement des caractère en miniscule\n" +
                "2- Des caractères en minuscules et majuscules\n" +
                "3- Des caractères et des chiffres\n" +
                "4- Caractères, chiffres et caratères spéciaux\n" +
                "Votre choix : ", 1, 4);

            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alphabetUpper = alphabetLower.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "!@#$%^&*()_+";

            switch (choixType)
            {
                case 1:

                    Outils.MotDePasse(alphabetLower, longueurMotdePasse, NBR_PROPOSITIONS);
                    break;

                case 2:

                    Outils.MotDePasse((alphabetLower + alphabetUpper), longueurMotdePasse, NBR_PROPOSITIONS);
                    break;

                case 3:

                    Outils.MotDePasse((alphabetLower + alphabetUpper + chiffres), longueurMotdePasse, NBR_PROPOSITIONS);
                    break;

                case 4:

                    Outils.MotDePasse((alphabetLower + alphabetUpper + chiffres + caracteresSpeciaux), longueurMotdePasse, NBR_PROPOSITIONS);
                    break;

                default:
                    Console.WriteLine("Erreur : Vous avez un numéro incorrecte.");
                    break;
            }



        }
    }
}
