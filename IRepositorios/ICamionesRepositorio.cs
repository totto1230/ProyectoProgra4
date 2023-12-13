using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface ICamionesRepositorio
    {
        public List<Camiones> ListaCamiones();

        public int InsertarCamion(Camiones camion);

        public Camiones ObtenerCamion(int codigoCamion);

        public Camiones ActualizarCamion(Camiones camion);

        public Camiones EliminarCamion(Camiones camion);

        public List<ModeloDDCamiones> DDCamiones();
    }
}
