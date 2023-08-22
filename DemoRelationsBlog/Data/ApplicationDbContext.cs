using DemoRelationsBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRelationsBlog.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public DbSet<Blog> blogs { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<BlogHeader> blogHeaders { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<BlogTag> blogTags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EFCore;Integrated Security=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
            new Blog()
            {
                Id = 1,
                Name = "Skyblog de Jennifer",
                SiteUri = "https://www.skyblog.com/jennifer"
            }, 
            new Blog()
            {
                Id = 2,
                Name = "EFCore Docs",
                SiteUri = "https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes"
            });
            
            modelBuilder.Entity<Post>().HasData(
            new Post()
            {
                Id = 1,
                Title = "Coucou",
                Content = "Mon premier post skyblog !!!! <3",
                BlogId = 1
            },
            new Post()
            {
                Id = 2,
                Title = "Brandon m'a largué...",
                Content = "Je suis triste.",
                BlogId = 1
            },
            new Post()
            {
                Id = 3,
                Title = "Required one-to-many",
                Content = "A one-to-many relationship is made up from:\nOne or more primary or alternate key properties on the principal entity; that is the \"one\" end of the relationship. For example, Blog.Id.\nOne or more foreign key properties on the dependent entity; that is the \"many\" end of the relationship. For example, Post.BlogId.\nOptionally, a collection navigation on the principal entity referencing the dependent entities. For example, Blog.Posts.\nOptionally, a reference navigation on the dependent entity referencing the principal entity.",
                BlogId = 2
            });
        }
        
    }
}
