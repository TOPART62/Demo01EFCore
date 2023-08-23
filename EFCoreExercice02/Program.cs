using System.Data;
using System.Linq.Expressions;
using EFCoreExercice02.Data;
using EFCoreExercice02;
using EFCoreExercice02.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADOExercices2
{
    internal class Program
    {
        static void Main()
        {
            // var
            int intUserChoice1;
            Client client;
            List<Client> listClients;
            // <using> permet de sortir de l'allocation à la fin du prg ou de la methode
            using var dbContext = new ApplicationDbContext();

            // ------------------------------
            do
            {
                // Choix de l'action
                intUserChoice1 = IHM.StartMenu();

                switch (intUserChoice1)
                {
                    case 0: // Quitter le programme
                        Environment.Exit(0);
                        break;

                    case 1: // Ajouter un client
                        Console.WriteLine("------- Ajouter un client : ");
                        (string outLastname, string outFirstname, string outTel) = IHM.StartClient();
                        client = new Client()
                        {
                            Lastname = outLastname,
                            Firstname= outFirstname,
                            Tel = outTel
                        };
                        dbContext.Clients.Add(client);
                        dbContext.SaveChanges();

                        break;

                    case 2: // Afficher la liste des clients
                        Console.WriteLine("------- Afficher la liste des clients : ");
                        listClients = dbContext.Clients.ToList();
                        foreach (var a in listClients)
                            Console.WriteLine($"    {a.Id} {a.Lastname} {a.Firstname} {a.Tel} ");
                        break;

                    case 3: // Afficher les réservations d'un client
                        Console.WriteLine("------- Afficher les réservations d'un client : ");
                        List<Booking> listReservations = dbContext.Bookings.ToList();
                        foreach (var a in listReservations)
                            //Console.WriteLine($"    {a.Id} {a.Lastname} {a.Firstname} {a.Tel} ");
                        break;
                        break;

                    case 4: // Ajouter une réservation
                        Console.WriteLine("------- Les clients : ");
                        listClients = dbContext.Clients.ToList();
                        foreach (var a in listClients)
                            // on pouvait aussi surcharger le ToStirng() pour afficher l'adresse
                            Console.WriteLine($"    {a.Id} {a.Lastname} {a.Firstname} {a.Tel} ");
                        Console.Write("Veuillez saisir l'ID du client sélectionné ? ");

                        Console.WriteLine("------- Ajouter une réservation : ");
                        (DateTime dateDebut, DateTime dateFin, EnumBookingStatus status, int idClient, int numChambre) = IHM.StartReservation();
                        Booking booking = new()
                        {
                            BeginningDate = dateDebut,
                            EndDate = dateFin,
                            Status = status,
                            ClientId = idClient
                        };
                        dbContext.Bookings.Add(booking);
                        dbContext.SaveChanges();

                        ;
                        BookingRoom bookingRoom = new()
                        {
                            BookingId = booking.Id,
                            RoomId = numChambre,
                            UpdateDate = DateTime.Now
                        };
                        dbContext.BookingRooms.Add(bookingRoom);
                        dbContext.SaveChanges();

                        break;

                    case 5: // Annuler une réservation

                        break;

                    case 6: // Afficher la liste des réservations
                        break;

                    case 7: // Afficher la liste des chambres libres
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice1 != 0);
        }
    }
}