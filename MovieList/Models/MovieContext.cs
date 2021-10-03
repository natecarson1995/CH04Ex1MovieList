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
        public DbSet<Genre> Genres { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre{GenreId = "A", Name="Action"},
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "Romcom" },
                new Genre { GenreId = "S", Name = "Scifi" }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Dear Evan Hansen",
                    Year = 2021,
                    Rating = 2,
                    GenreId="D"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Malignant",
                    Year = 2021,
                    Rating = 4,
                    GenreId="D"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Cry Macho",
                    Year = 2021,
                    Rating = 3,
                    GenreId="C"
                }
                );
        }
    }
}
