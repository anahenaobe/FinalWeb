using FinalWeb.Models;
using System.Collections.ObjectModel;

namespace FinalWeb.Models
{
    public class Respuesta
    {
        public int id { get; set; }
        public string Contenido { get; set; } = string.Empty;
        public int PreguntaId { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public Pregunta? Pregunta { get; set; }
    }
}
