using api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMovies() {
            return Ok(MoviesDataStore.Current.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id) {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) {
                return NotFound(new { Message = "Movie not found" });
            }
            return Ok(movie);
        }
    }
}