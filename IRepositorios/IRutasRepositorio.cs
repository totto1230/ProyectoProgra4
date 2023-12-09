using ProyectoPrograCuatro.Models;


namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IRutasRepositorio
    {
        public List<Rutas> ListaRutas();

        public int InsertarRuta(Rutas ruta);

        public Rutas ObtenerRuta(int codigoruta);

        // Obtiene una lista de clientes disponibles
        List<Clientes> ObtenerClientesDisponibles();

        // Obtiene una lista de choferes disponibles
        List<Choferes> ObtenerChoferesDisponibles();

        // Obtiene una lista de camiones disponibles
        List<Camiones> ObtenerCamionesDisponibles();
    }
}
