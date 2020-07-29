using Lab23.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Data
{
    public class MovieListContext : DbContext
    {
        public MovieListContext(DbContextOptions<MovieListContext> options) : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies")
                .Property(x => x.Title)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Genre)
                    .HasMaxLength(20)
                    .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Runtime)
                .IsRequired();
                   

        }

    }
}
