using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IBLL
{
    public interface IChoferesBLL
    {
        public List<Choferes> ListaChoferes();
        public int InsertarChofer(Choferes chofer);

        public Choferes ObtenerChofer(int idchofer);

        public Choferes ActualizarChofer(Choferes chofer);

        public int EliminarChofer(int idchofer);
    }
}
