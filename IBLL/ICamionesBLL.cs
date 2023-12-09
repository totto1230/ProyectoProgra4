using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IBLL
{
    public interface ICamionesBLL
    {

        public List<Camiones> ListaCamiones();
        public int InsertarCamion(Camiones camion);

        public Camiones ObtenerCamion(int codigoCamion);

        public Camiones ActualizarCamion(Camiones camion);

        public Camiones EliminarCamion(Camiones camion);

        public List<ModeloDD> DDCamiones();

    }
}
