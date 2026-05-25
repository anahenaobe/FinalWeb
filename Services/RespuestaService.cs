using FinalWeb.DAO;
using FinalWeb.Models;
using FinalWeb.Services;
using FinalWeb.DAO;
using FinalWeb.Models;

namespace FinalWeb.Services;

public class RespuestaService : IRespuestaService
{
    private readonly IRespuestaDAO _respuestaDAO;
    private readonly IPreguntaDAO _preguntaDAO;

    public RespuestaService(IRespuestaDAO respuestaDAO, IPreguntaDAO preguntaDAO)
    {
        _respuestaDAO = respuestaDAO;
        _preguntaDAO = preguntaDAO;
    }

    public async Task<Respuesta> CrearRespuestaAsync(Respuesta respuesta)
    {
        var resultado = await _respuestaDAO.CrearAsync(respuesta);
        await CambiarEstadoPregunta(respuesta.PreguntaId);
        return resultado;
    }

    private async Task CambiarEstadoPregunta(int preguntaId)
    {
        var pregunta = await _preguntaDAO.ObtenerPorIdAsync(preguntaId);
        if (pregunta != null)
        {
            pregunta.Estado = "Resuelta";
            await _preguntaDAO.ActualizarAsync(pregunta);
        }
    }
}