using api.Models;
using api.Services.interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly IMovieInfoRepository _repository;
    private readonly IMapper _mapper;

    public MoviesController(IMovieInfoRepository repository, IMapper mapper)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public IActionResult GetMovies()
    {
      var movies = _repository.GetMovies();
      var results = _mapper.Map<IEnumerable<MovieDto>>(movies);
      return Ok(results);
    }

    [HttpGet("{id}")]
    public IActionResult GetMovie(int id, bool includeCast)
    {
      var movie = _repository.GetMovie(id, includeCast);
      if (movie == null)
      {
        return NotFound(new { Message = "Movie not found" });
      }

      var result = _mapper.Map<MovieDto>(movie);
      return Ok(result);
    }
  }
}