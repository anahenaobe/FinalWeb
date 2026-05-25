using FinalWeb.Models;
using Microsoft.EntityFrameworkCore;
using FinalWeb.Models;

namespace FinalWeb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pregunta> Preguntas { get; set; }
    public DbSet<Respuesta> Respuestas { get; set; }

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}