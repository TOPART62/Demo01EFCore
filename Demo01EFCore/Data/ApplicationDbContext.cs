using Demo01EFCore.Models;
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
        public ApplicationDbContext() : base()
        { 
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EfCore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seed => "graine de la BD ; données initiales lors de l'application de la migration correspondante
            var studentDefault  = new Student()
            {
                Id = 1000,
                FirstName = "Default",
                LastName = "Default",
                Phone = "0101010101",
                Email = "xxx@xxx.com"
            };
            modelBuilder.Entity<Student>().HasData(studentDefault);
        }
    }
}
