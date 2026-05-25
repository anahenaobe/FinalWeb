using FinalWeb.Data;
using FinalWeb.DAO;
using FinalWeb.Models;
using FinalWeb.Data;
using FinalWeb.Models;

namespace FinalWeb.DAO;

public class RespuestaDAO : IRespuestaDAO
{
    private readonly AppDbContext _context;

    public RespuestaDAO(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Respuesta> CrearAsync(Respuesta respuesta)
    {
        _context.Respuestas.Add(respuesta);
        await _context.SaveChangesAsync();
        return respuesta;
    }
}