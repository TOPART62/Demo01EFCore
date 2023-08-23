using EFCoreExercice02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02
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
        public static (string strLastname, string strFirstname, string strTel ) StartClient()
        {
            while (true)
            {
                Console.Write("Veuillez entrer le nom du client ? ");
                string strLastname = Console.ReadLine()!;

                Console.Write("Veuillez entrer le prénom du client ? ");
                string strFirstname = Console.ReadLine()!;

                Console.Write("Veuillez entrer le téléphone du client ? ");
                string strTel = Console.ReadLine()!;

                return (strLastname, strFirstname, strTel);
            }
        }
        public static (DateTime dateDebut, DateTime dateFin, EnumBookingStatus enmBooking, int idClient, int numChambre) StartReservation()
        {
            while (true)
            {
                Console.Write("Veuillez saisir l'ID du client ? ");
                string strTmp = Console.ReadLine()!;
                int intIdClient;
                while (!int.TryParse(strTmp, out intIdClient))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strTmp = Console.ReadLine()!;
                }

                Console.Write("Veuillez entrer la date de début de réservation ? ");
                strTmp = Console.ReadLine()!;
                DateTime datDebut;
                while (!DateTime.TryParse(strTmp, out datDebut))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strTmp = Console.ReadLine()!;
                }
                Console.Write("Veuillez entrer la date de fin de réservation ? ");
                DateTime datFin;
                while (!DateTime.TryParse(strTmp, out datFin))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strTmp = Console.ReadLine()!;
                }

                Console.Write("Veuillez saisir le numéro de chambre ? ");
                strTmp = Console.ReadLine()!;
                int intNumChambre;
                while (!int.TryParse(strTmp, out intNumChambre))
                {
                    Console.Write("\t\tSaisie invalide ! Réessayer : ");
                    strTmp = Console.ReadLine()!;
                }

                return (datDebut,datFin, EnumBookingStatus.inProgress, intIdClient, intNumChambre);
            }
        }

    }
}
