namespace FinalWeb.DAO
{
 
    public interface IPreguntaDAO
    {
        Task<PreguntaDAO> CrearAsync(PreguntaDAO pregunta);
        Task<IEnumerable<PreguntaDAO>> ListarPorEstadoAsync(string estado);
        Task<PreguntaDAO?> ObtenerPorIdAsync(int id);
        Task ActualizarAsync(PreguntaDAO pregunta);
    }
}