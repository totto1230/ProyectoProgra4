using ProyectoPrograCuatro.Models;
using System.Timers;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IRutasRepositorio
    {
        public List<Rutas> ListaRutas();

        public int InsertarRuta(Rutas ruta);

        public Rutas ObtenerRuta(int codigoruta);

    }
}
