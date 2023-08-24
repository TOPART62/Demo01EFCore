using EFCoreExercice02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Data
{
    internal class ApplicationDbContext : DbContext
    {
// Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 
        public ApplicationDbContext()
#pragma warning restore CS8618 
        {
        }

        public DbSet<Room> Rooms{ get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingRoom> BookingRooms{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EFCore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
            new Client()
            {
                Id = 1,
                Lastname = "Toto",
                Firstname = "Toto",
                Tel = "0101010101"
            });
            modelBuilder.Entity<Room>().HasData(
            new Room()
            {
                Id = 1,
                Status = 0, 
                BedsNumber = 1,
                RoomRate = 125.50M
            });
            modelBuilder.Entity<Booking>().HasData(
            new Booking()
            {
                Id = 1,
                Status = 0,
                ClientId = 1
            });
            modelBuilder.Entity<BookingRoom>().HasData(
            new BookingRoom()
            {
                Id = 1,
                BookingId = 1,
                RoomId = 1
            });
            //modelBuilder.Entity<BookingRoom>().HasKey(
            //  br => new
            //  {
            //      br.BookingId,
            //      br.RoomId
            //  });
        }

    }
}