using System.Collections.Generic;
using api.Models;

namespace api
{
    public class MoviesDataStore
    {
        public static MoviesDataStore Current { get; } = new MoviesDataStore();
        public List<MovieDto> Movies { get; set; }
        public MoviesDataStore()
        {
            Movies = new List<MovieDto>()
            {
                new MovieDto{ 
                    Id = 1,
                    Name = "Star Wars", 
                    Description = "A long time ago in a galaxy far, far away...",
                    Cast = new List<CastDto>()
                    {
                        new CastDto{ Id = 1, Name = "Mark Hamill", Character = "Luke Skywalker" },
                        new CastDto{ Id = 2, Name = "Carrie Fisher", Character = "Leia Organa" },
                        new CastDto{ Id = 3, Name = "Harrison Ford", Character = "Han Solo" },
                        new CastDto{ Id = 4, Name = "David Prowse", Character = "Darth Vader" }
                    },
                },
                new MovieDto{ 
                    Id = 2, 
                    Name = "Lord of the Rings", 
                    Description = "A long time ago in a galaxy far, far away...",
                    Cast = new List<CastDto>()
                    {
                        new CastDto{ Id = 1, Name = "Elijah Wood", Character = "Frodo" },
                        new CastDto{ Id = 2, Name = "Ian McKellen", Character = "Gandalf" },
                        new CastDto{ Id = 3, Name = "Viggo Mortensen", Character = "Legolas" },
                        new CastDto{ Id = 4, Name = "Orlando Bloom", Character = "Aragorn" }
                    },
                },
            };
        }
    }
}