using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Dear Evan Hansen",
                    Year = 2021,
                    Rating = 2
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Malignant",
                    Year = 2021,
                    Rating = 4
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Cry Macho",
                    Year = 2021,
                    Rating = 3
                }
                );
        }
    }
}
