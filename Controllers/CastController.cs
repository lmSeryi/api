using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/casts")]
    public class CastController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCast(int movieId) 
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(m => m.Id == movieId);
            Console.WriteLine(movie);
            if (movie == null)
            {
                return NotFound(new { Message = "Movie not found" });
            }
            return Ok(movie.Cast);
        }

        [HttpGet("{id}")]
        public IActionResult GetCast(int movieId, int id) 
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(m => m.Id == movieId);
            Console.WriteLine(movie);
            if (movie == null)
            {
                return NotFound(new { Message = "Movie not found" });
            }
            var cast = movie.Cast.FirstOrDefault(c => c.Id == id);
            if (cast == null)
            {
                return NotFound(new { Message = "Cast not found" });
            }
            return Ok(cast);
        }
    }
}