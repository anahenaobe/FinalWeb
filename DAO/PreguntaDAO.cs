using FinalWeb.Api.Data;
using FinalWeb.Api;
using FinalWeb.DAO;
using Microsoft.EntityFrameworkCore;
using FinalWeb.Data;
using FinalWeb.Models;

namespace FinalWeb.DAO;

public class PreguntaDAO : IPreguntaDAO
{
    private readonly AppDbContext _context;

    public PreguntaDAO(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Pregunta> CrearAsync(Pregunta pregunta)
    {
        _context.Preguntas.Add(pregunta);
        await _context.SaveChangesAsync();
        return pregunta;
    }

    public async Task<IEnumerable<Pregunta>> ListarPorEstadoAsync(string estado)
    {
        return await _context.Preguntas
            .Where(p => p.Estado.ToLower() == estado.ToLower())
            .Include(p => p.Respuestas)
            .ToListAsync();
    }

    public async Task<Pregunta?> ObtenerPorIdAsync(int id)
    {
        return await _context.Preguntas.FindAsync(id);
    }

    public async Task ActualizarAsync(Pregunta pregunta)
    {
        _context.Preguntas.Update(pregunta);
        await _context.SaveChangesAsync();
    }

    public Task<PreguntaDAO> CrearAsync(PreguntaDAO pregunta)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<PreguntaDAO>> IPreguntaDAO.ListarPorEstadoAsync(string estado)
    {
        throw new NotImplementedException();
    }

    Task<PreguntaDAO?> IPreguntaDAO.ObtenerPorIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task ActualizarAsync(PreguntaDAO pregunta)
    {
        throw new NotImplementedException();
    }
}