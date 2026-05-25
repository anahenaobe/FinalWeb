using FinalWeb.Models;
using Microsoft.AspNetCore.Mvc;
using FinalWeb.Models;
using FinalWeb.Services;

namespace FinalalWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RespuestasController : ControllerBase
{
    private readonly IRespuestaService _service;

    public RespuestasController(IRespuestaService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Crear([FromBody] Respuesta respuesta)
    {
        var resultado = await _service.CrearRespuestaAsync(respuesta);
        return CreatedAtAction(nameof(Crear), new { id = resultado.Id }, resultado);
    }
}
