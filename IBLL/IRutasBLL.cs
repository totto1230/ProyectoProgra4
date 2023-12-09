using ProyectoPrograCuatro.Models;


namespace ProyectoPrograCuatro.IBLL
{
    public interface IRutasBLL
    {
        public List<Rutas> ListaRutas();

        public int InsertarRuta(Rutas ruta);

        public Rutas ObtenerRuta(int codigoruta);

<<<<<<< HEAD
        //public Rutas GenerarReporte(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);
=======
        // Obtiene una lista de clientes disponibles
        List<Clientes> ObtenerClientesDisponibles();

        // Obtiene una lista de choferes disponibles
        List<Choferes> ObtenerChoferesDisponibles();

        // Obtiene una lista de camiones disponibles
        List<Camiones> ObtenerCamionesDisponibles();
>>>>>>> f2b20ea607c0e7a7837eeb82fba8e65d0872d246
    }
}
