using ProyectoPrograCuatro.Models;


namespace ProyectoPrograCuatro.IBLL
{
    public interface IRutasBLL
    {
        public List<Rutas> ListaRutas();

        public int InsertarRuta(Rutas ruta);

        public Rutas ObtenerRuta(int codigoruta);

        //public Rutas GenerarReporte(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);
    }
}
