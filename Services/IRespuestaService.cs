using FinalWeb.Models;
using FinalWeb.Models;

namespace FinalWeb.Services;

public interface IRespuestaService
{
    Task<RespuestaService> CrearRespuestaAsync(RespuestaService respuesta);
    Task CrearRespuestaAsync(Respuesta respuesta);
}