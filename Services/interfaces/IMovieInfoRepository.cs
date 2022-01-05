using System.Collections.Generic;
using api.Entities;

namespace api.Services.interfaces
{
  public interface IMovieInfoRepository
  {
    IEnumerable<Movie> GetMovies();
    Movie GetMovie(int id, bool includeCast);
    IEnumerable<Cast> GetCasts(int movieId);
    Cast GetCast(int movieId, int castId);
    void AddCast(int movieId, Cast cast);
    void UpdateCast(int movieId, Cast cast);
    void DeleteCast(Cast cast);
    bool Save();
  }
}