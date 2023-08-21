using EFCoreExercice01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFCore.Data
{
    internal class ApplicationDbContext : DbContext
    {
#nullable disable // permet de supprimer les Warnings entre le blocs de code "disable" et "enable"
        public DbSet<Adresse> Adresses { get; set; }
        public ApplicationDbContext() : base()
        {
        }
#nullable enable

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EfCore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var adresseDefault  = new Adresse()
            {
                Id = 1, 
                NumeroVoie = "22 bis",
                Complement = "",
                IntituleVoie = "rue tutu",
                Commune = "turlututu",
                CodePostal = 99999
            };
            modelBuilder.Entity<Adresse>().HasData(adresseDefault);
        }
    }
}
