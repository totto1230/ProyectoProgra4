using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface ICamionesRepositorio
    {
        public List<Camiones> ListaCamiones();

        public int InsertarCamion(Camiones camion);

        public Camiones ObtenerCamion(int Codigo);

        public Camiones ActualizarCamion(Camiones camion);

        public int EliminarCamion(int Codigo);
    }
}
