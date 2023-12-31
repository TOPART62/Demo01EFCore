﻿using System.Data;
using System.Linq.Expressions;
using Demo01EFCore.Data;
using EFCoreExercice01;
using EFCoreExercice01.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;


namespace ADOExercices2
{
    internal class Program
    {
        static void Main()
        {
            // variables
            int intUserChoice1;
            int intID;
            List<Adresse> adresses;
            Adresse adresse;
            // <using> permet de sortir de l'allocation à la fin du prg ou de la methode
            using var context = new ApplicationDbContext();

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

                    case 1: // Voir les adresses
                        Console.WriteLine("------- Liste des adresses : ");
                        adresses = context.Adresses.ToList();
                        foreach (var a in adresses)
                            // on pouvait aussi surcharger le ToStirng() pour afficher l'adresse
                            Console.WriteLine($"    {a.Id} {a.NumeroVoie} {a.Complement} {a.IntituleVoie} {a.CodePostal} {a.Commune}");
                        break;

                    case 2: // Ajouter une adresse
                        try
                        {
                            Console.WriteLine("------- Ajouter une adresse ");
                            (string strNumVoie, string strComplement, string strIntituleVoie, string strCommune, int intCodePostal) = IHM.StartAdresse();
                            adresse = new Adresse()
                            {
                                NumeroVoie = strNumVoie,
                                Complement = strComplement,
                                IntituleVoie = strIntituleVoie,
                                Commune = strCommune,
                                CodePostal = intCodePostal
                            };
                            context.Adresses.Add(adresse);
                            context.SaveChanges();
                        }
                        catch (Exception ex) 
                        { 
                            Console.WriteLine(ex.ToString());   
                        }
                        break;

                    case 3: // Editer une adresse
                        Console.WriteLine("-------- Recherche des adresses par le nom de la commune");
                        string strCommuneSearch = IHM.StartRechercheAdresseParNom();
                        //adresses = context.Adresses.Where(a => a.Commune!.StartsWith(strCommuneSearch)).ToList()!;
                        adresses = context.Adresses.Where(a => a.Commune!.Contains(strCommuneSearch)).ToList()!;
                        foreach (var a in adresses)
                            Console.WriteLine($"    {a.Id} {a.NumeroVoie} {a.Complement} {a.IntituleVoie} {a.CodePostal} {a.Commune}");
                        // Sélectionner un Id d'adresse
                        intID = IHM.SelectIdAdresse();
                        adresse = context.Adresses.Find(intID)!;
                        Console.WriteLine($"    {adresse.Id} {adresse.NumeroVoie} {adresse.Complement} {adresse.IntituleVoie} " +
                            $"{adresse.CodePostal} {adresse.Commune}");
                        break;

                    case 4: // Supprimer une adresse
                        Console.WriteLine("-------- Recherche des adresses par le nom de la commune");
                        string strCommuneSearc2 = IHM.StartRechercheAdresseParNom();
                        adresses = context.Adresses.Where(a => a.Commune!.StartsWith(strCommuneSearc2)).ToList();
                        foreach (var a in adresses)
                            Console.WriteLine($"    {a.Id} {a.NumeroVoie} {a.Complement} {a.IntituleVoie} {a.CodePostal} {a.Commune}");
                        // Sélectionner un Id d'adresse
                        intID = IHM.SelectIdAdresse();
                        adresse = context.Adresses.Find(intID)!;
                        context.Adresses.Remove(adresse);
                        context.SaveChanges();
                        Console.WriteLine($"Adresse {intID} supprimée !!!");
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (intUserChoice1 != 0);
        }
    }
}