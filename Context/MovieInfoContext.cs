using System;
using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
  public class MovieInfoContext : DbContext
  {
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Movie> Movies { get; set; }

    public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Movie>()
          .HasData(
              new Movie { Id = 1, Name = "The Shawshank Redemption", Description = "Two imprisoned" },
              new Movie { Id = 2, Name = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." },
              new Movie { Id = 3, Name = "The Godfather: Part II", Description = "The early life and career of Vito Corleone in 1920s New York is portrayed while his son, Michael, expands and tightens his grip on his crime syndicate stretching from Lake Tahoe, Nevada to pre-revolution 1958 Cuba." },
              new Movie { Id = 4, Name = "The Dark Knight", Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice." },
              new Movie { Id = 5, Name = "12 Angry", Description = "A look at the relationship between the life of a young" }
          );

      modelBuilder.Entity<Cast>()
          .HasData(
              new Cast { Id = 1, Name = "Tim Robbins", Character = "Andy Dufresne", MovieId = 1, Age = 50 },
              new Cast { Id = 2, Name = "Morgan Freeman", Character = "Andy Dufresne", MovieId = 1, Age = 50 },
              new Cast { Id = 3, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 1, Age = 50 },
              new Cast { Id = 4, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 2, Age = 50 },
              new Cast { Id = 5, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 3, Age = 50 },
              new Cast { Id = 6, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 4, Age = 50 },
              new Cast { Id = 7, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 5, Age = 50 },
              new Cast { Id = 8, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 1, Age = 50 },
              new Cast { Id = 9, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 2, Age = 50 },
              new Cast { Id = 10, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 3, Age = 50 },
              new Cast { Id = 11, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 4, Age = 50 },
              new Cast { Id = 12, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 5, Age = 50 },
              new Cast { Id = 13, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 1, Age = 50 },
              new Cast { Id = 14, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 2, Age = 50 },
              new Cast { Id = 15, Name = "Bob Gunton", Character = "Andy Dufresne", MovieId = 3, Age = 50 }
          );
      base.OnModelCreating(modelBuilder);
    }
  }
}