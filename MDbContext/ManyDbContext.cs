using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Many_to_Many.Many_Models;
using Microsoft.EntityFrameworkCore;

namespace Many_to_Many.MDbContext
{
    public class ManyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Server=KELLY;Database=Library3;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
            .HasMany(q=>q.Books) //we check from primary entity 
            .WithMany(bk=>bk.M_Authors) //we check from dependent entity
            .UsingEntity(bc => bc.ToTable("AuthorsBooks")); //Using it to create join table
        }

        public DbSet<Author> MAuthors { get; set; }
        public DbSet<Book> Mbooks { get; set; }

    }
}