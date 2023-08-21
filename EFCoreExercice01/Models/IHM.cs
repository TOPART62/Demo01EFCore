using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice01.Models
{
    internal static class IHM
    {
        public static int StartMenu()
        {
            Console.WriteLine("\n=== Menu principal ===\n");

            while (true)
            {
                Console.WriteLine("\t1. Voir les adresses");
                Console.WriteLine("\t2. Ajouter une adresse");
                Console.WriteLine("\t3. Editer une adresse");
                Console.WriteLine("\t4. Supprimer une adresse");
                Console.WriteLine("\t0. Quitter le programme\n");

                Console.Write("\nEntrez votre choix : ");
                string userChoice = Console.ReadLine()!;
                Console.WriteLine("  ");
                int intChoixMenu;
                while (!int.TryParse(userChoice, out intChoixMenu) && intChoixMenu < 0 || intChoixMenu > 5)
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    userChoice = Console.ReadLine()!;
                }
                return (intChoixMenu);
            }
        }
        public static (string numVoie, string complementAdr, string intituleVoie, string commune, int codePostal) StartAdresse()
        {
            while (true)
            {
                Console.Write("Veuillez entrer le numéro de voie ? ");
                string strNumVoie = Console.ReadLine()!;

                Console.Write("Veuillez entrer le complement d'adresse ? ");
                string strComplement = Console.ReadLine()!;

                Console.Write("Veuillez entrer l'intitulé de la voie ? ");
                string strIntituleVoie = Console.ReadLine()!;

                Console.Write("Veuillez entrer la commune ? ");
                string strCommune = Console.ReadLine()!;

                Console.Write("Veuillez entrer le code postal ? ");
                string strCodePostal = Console.ReadLine()!;
                int intCodePostal = 0;      
                while (!int.TryParse(strCodePostal, out intCodePostal))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strCodePostal = Console.ReadLine()!;
                }

                return (strNumVoie, strComplement, strIntituleVoie, strCommune, intCodePostal);
            }
        }
        public static string StartRechercheAdresseParNom()
        {
            while (true)
            {
                Console.Write("Veuillez entrer le début du nom de la commune ? ");
                string strCommune = Console.ReadLine()!;

                return strCommune;
            }
        }
        public static int SelectIdAdresse()
        {
            while (true)
            {
                Console.Write("Veuillez saisir l'ID de la commune à éditer/supprimer ? ");
                string strID = Console.ReadLine()!;
                int intID= 0;
                while (!int.TryParse(strID, out intID))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strID = Console.ReadLine()!;
                }

                return intID;
            }
        }

    }
}
