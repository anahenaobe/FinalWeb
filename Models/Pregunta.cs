using FinalWeb.Api;
using FinalWeb.Models;
using System.Collections.ObjectModel;

namespace FinalWeb.Models
{
    public class Pregunta
    {
        public int id { get; set; }
        public string Enunciado { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Estado { get; set; } = "Sin resolver";
        public Collection<Respuesta> Respuestas { get; set; } = new list <Respuesta>();

    }
}
