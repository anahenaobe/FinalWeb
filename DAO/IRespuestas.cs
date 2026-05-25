using FinalWeb.Models;
using FinalWeb.Models;

namespace FinalWeb.DAO;

public interface IRespuestaDAO
{
    Task<Respuesta> CrearAsync(Respuesta respuesta);
}
