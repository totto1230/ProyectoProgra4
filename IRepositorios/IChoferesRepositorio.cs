using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IChoferesRepositorio
    {
        public List<Choferes> ListaChoferes();

        public int InsertarChofer(Choferes chofer);

        public Choferes ObtenerChofer(int Codigo);

        public Choferes ActualizarChofer(Choferes chofer);

        public Choferes EliminarChofer(Choferes chofer);
    }
}
