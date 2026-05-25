using FinalWeb.Services;
using Microsoft.AspNetCore.Mvc;
using FinalWeb.Models;
using FinalWeb.Services;

    namespace FinalWeb.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : ControllerBase
    {
        private readonly IPreguntaService_service;

        public PreguntasController(IPreguntaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Pregunta pregunta)
        {
            var resultado = await _service.CrearPreguntaAsync(pregunta);
            return CreatedAtAction(nameof(Crear), new { id = resultado.Id }, resultado);
        }

    [HttpGet("{estado}")]
    public async Task<IActionResult> ListarPorEstado(string estado)
    {
        var lista = await _service.ListarPorEstadoAsync(estado);
        return Ok(lista);
    }
}