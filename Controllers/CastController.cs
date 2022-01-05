using System;
using System.Collections.Generic;
using System.Linq;
using api.Entities;
using api.Models;
using api.Services;
using api.Services.interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
  [ApiController]
  [Route("api/movies/{movieId}/casts")]
  public class CastController : ControllerBase
  {
    private readonly ILogger<CastController> _logger;
    private readonly IMailService _mailService;
    private readonly IMovieInfoRepository _repository;
    private readonly IMapper _mapper;
    public CastController(ILogger<CastController> logger, IMailService mailService, IMovieInfoRepository repository, IMapper mapper)
    {
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
      _mailService = mailService;
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public IActionResult GetCast(int movieId)
    {
      try
      {
        var casts = _repository.GetCasts(movieId);

        if (casts.Count() == 0)
        {
          return NotFound(new { Message = "Cast not found" });
        }
        
        var results = _mapper.Map<IEnumerable<CastDto>>(casts);

        return Ok(results);
      }
      catch (Exception ex)
      {
        _logger.LogError($"Exception thrown while getting cast for movie with id {movieId}.", ex);
        return StatusCode(500, new { Message = "An unexpected error occurred." });
      }
    }

    [HttpGet("{id}", Name = "GetCast")]
    public IActionResult GetCast(int movieId, int id)
    {
      var cast = _repository.GetCast(movieId, id);
      if (cast == null)
      {
        return NotFound(new { Message = "Cast not found" });
      }

      var result = _mapper.Map<CastDto>(cast);

      return Ok(result);
    }

    [HttpPost]
    public IActionResult CreateCast(int movieId, [FromBody] CastForCreationDto cast)
    {
      var movie = _repository.GetMovie(movieId, false);

      if (movie == null)
      {
        return NotFound(new { Message = "Movie not found" });
      }

      var newCast = _mapper.Map<Cast>(cast);

      _repository.AddCast(movieId, newCast);

      if (!_repository.Save())
      {
        return StatusCode(500, new { Message = "An unexpected error occurred." });
      }

      var createdCast = _mapper.Map<CastForCreationDto>(newCast);

      return CreatedAtRoute(nameof(GetCast), new { movieId, id = newCast.Id }, createdCast);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCast(int movieId, int id, [FromBody] UpdateCastDto cast)
    {
      var movie = _repository.GetMovie(movieId, false);
      if (movie == null)
      {
        return NotFound(new { Message = "Movie not found" });
      }

      var castFromStore = _repository.GetCast(movieId, id);
      if (castFromStore == null)
      {
        return NotFound(new { Message = "Cast not found" });
      }

      _mapper.Map(cast, castFromStore);
      
      _repository.UpdateCast(movieId, castFromStore);

      if (!_repository.Save())
      {
        return StatusCode(500, new { Message = "An unexpected error occurred." });
      }

      return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult PartiallyUpdateCast(int movieId, int id, [FromBody] JsonPatchDocument<UpdateCastDto> patchDoc)
    {
      var movie = _repository.GetMovie(movieId, false);
      if (movie == null)
      {
        return NotFound(new { Message = "Movie not found" });
      }

      var castFromStore = _repository.GetCast(movieId, id);
      if (castFromStore == null)
      {
        return NotFound(new { Message = "Cast not found" });
      }

      var castToPatch = _mapper.Map<UpdateCastDto>(castFromStore);

      patchDoc.ApplyTo(castToPatch, ModelState);

      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (!TryValidateModel(castToPatch))
      {
        return BadRequest(ModelState);
      }

      _mapper.Map(castToPatch, castFromStore);

      _repository.UpdateCast(movieId, castFromStore);

      if (!_repository.Save())
      {
        return StatusCode(500, new { Message = "An unexpected error occurred." });
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCast(int movieId, int id)
    {
      var movie = _repository.GetMovie(movieId, false);
      if (movie == null)
      {
        return NotFound(new { Message = "Movie not found" });
      }

      var castFromStore = _repository.GetCast(movieId, id);
      if (castFromStore == null)
      {
        return NotFound(new { Message = "Cast not found" });
      }

      _mailService.Send("Cast Deleted", $"{castFromStore.Name} has been deleted.");

      _repository.DeleteCast(castFromStore);
      
      if (!_repository.Save())
      {
        return StatusCode(500, new { Message = "An unexpected error occurred." });
      }

      return NoContent();
    }
  }
}