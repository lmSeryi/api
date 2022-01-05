using System;
using api.Context;
using api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class DummyController : ControllerBase
  {
    private readonly IMailService _mailService;
    private readonly MovieInfoContext _context;

    public DummyController(IMailService mailService, MovieInfoContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
      _mailService = mailService;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello World!");
    }

    [HttpPost]
    public IActionResult Post()
    {
      _mailService.Send("", "");
      return Ok();
    }
  }
}
