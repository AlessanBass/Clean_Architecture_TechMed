using Microsoft.AspNetCore.Mvc;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Application.InputModels;

namespace TechMed.WebAPI.Controllers;
[ApiController]
[Route("/api/v0.1/")] 
public class ExameController : ControllerBase
{
   private readonly IExameService _examesService;
   public List<ExameViewModel> Exames => _examesService.GetAll();
   public ExameController(IExameService service) => _examesService = service;

   [HttpGet("exames")]
   public IActionResult Get()
   {
      return Ok(Exames);

   }

   [HttpPost("exames")]
   public IActionResult Post([FromBody] NewExameInputModel exame)
   {
      _examesService.Create(exame);
      return CreatedAtAction(nameof(Get), exame);
 
   }

}
