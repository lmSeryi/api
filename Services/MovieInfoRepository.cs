using System;
using System.Collections.Generic;
using System.Linq;
using api.Context;
using api.Entities;
using api.Services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.Services
{
  public class MovieInfoRepository : IMovieInfoRepository
  {
    private readonly MovieInfoContext _context;

    public MovieInfoRepository(MovieInfoContext context)
    {
      _context = context ?? throw new System.ArgumentNullException(nameof(context));
    }

    public Cast GetCast(int movieId, int castId)
    {
      var cast = _context.Casts.Where(c => c.MovieId == movieId && c.Id == castId).FirstOrDefault();
      return cast;
    }

    public IEnumerable<Cast> GetCasts(int movieId)
    {
      var casts = _context.Casts.Where(c => c.MovieId == movieId).ToList();
      return casts;
    }

    public Movie GetMovie(int id, bool includeCast)
    {
      if (includeCast)
      {
        return _context.Movies
            .Include(m => m.Cast)
            .Where(m => m.Id == id)
            .FirstOrDefault();
      }
      var movie = _context.Movies
          .Where(m => m.Id == id)
          .FirstOrDefault();
      return movie;
    }

    public IEnumerable<Movie> GetMovies()
    {
      var movies = _context.Movies.OrderBy(m => m.Name).ToList();
      return movies;
    }

    public void AddCast(int movieId, Cast cast)
    {
      var movie = GetMovie(movieId, false);
      movie.Cast.Add(cast);
    }

    public void AddMovie(Movie movie)
    {
      _context.Movies.Add(movie);
    }

    public void UpdateCast(int movieId, Cast cast)
    {

    }

    public void DeleteCast(Cast cast)
    {
      _context.Casts.Remove(cast);
    }

    public bool Save()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}