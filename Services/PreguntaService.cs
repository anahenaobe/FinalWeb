using FinalWeb.DAO;
using FinalWeb.Models;
using FinalWeb.Services;
using FinalWeb.DAO;
using FinalWeb.Models;

namespace FinalWeb.Services;

public class PreguntaService : IPreguntaService
{
    private readonly IPreguntaDAO _preguntaDAO;

    public PreguntaService(IPreguntaDAO preguntaDAO)
    {
        _preguntaDAO = preguntaDAO;
    }

    public async Task<Pregunta> CrearPreguntaAsync(Pregunta pregunta)
    {
        return await _preguntaDAO.CrearAsync(pregunta);
    }

    public async Task<IEnumerable<Pregunta>> ListarPorEstadoAsync(string estado)
    {
        return await _preguntaDAO.ListarPorEstadoAsync(estado);
    }
}