using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice01
{
    internal static class IHM
    {
        public static int StartMenu()
        {
            Console.WriteLine("\n=== Menu principal ===\n");

            while (true)
            {
                Console.WriteLine("\t1. Ajouter un client");
                Console.WriteLine("\t2. Afficher la liste des clients");
                Console.WriteLine("\t3. Afficher les réservations d'un client");
                Console.WriteLine("\t4. Ajouter une réservation");
                Console.WriteLine("\t5. Annuler une réservation");
                Console.WriteLine("\t6. Afficher la liste des réservations");
                Console.WriteLine("\t7. Afficher la liste des chambres libres");
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
                return intChoixMenu;
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
                int intCodePostal;
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
                int intID;
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
