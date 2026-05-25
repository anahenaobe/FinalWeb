using FinalWeb.Models;
using FinalWeb.Models;

namespace FinalWeb.Services;

public interface IPreguntaService
{
    Task<Pregunta> CrearPreguntaAsync(Pregunta pregunta);
    Task<IEnumerable<Pregunta>> ListarPorEstadoAsync(string estado);
}