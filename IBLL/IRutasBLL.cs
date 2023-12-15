using ProyectoPrograCuatro.Models;


namespace ProyectoPrograCuatro.IBLL
{
    public interface IRutasBLL
    {
        public List<Rutas> ListaRutas();

        public int InsertarRuta(Rutas ruta);

        public Rutas ObtenerRuta(int codigoRuta);

        //public int ObtenerEstado(int codigoRuta);

        public Rutas ActualizarRuta(Rutas ruta);

  
    }
}
