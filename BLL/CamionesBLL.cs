using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using ProyectoPrograCuatro.Repositorios;

namespace ProyectoPrograCuatro.BLL
{
    public class CamionesBLL : ICamionesBLL
    {
        private readonly ICamionesRepositorio _camionesRepositorio;

        public CamionesBLL(ICamionesRepositorio camionRepositorio)
        {
            _camionesRepositorio = camionRepositorio;
        }

        public Camiones ObtenerCamion(int codigoCamion)
        {
            try
            {
                return _camionesRepositorio.ObtenerCamion(codigoCamion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertarCamion(Camiones camion)
        {
            try
            {
                return _camionesRepositorio.InsertarCamion(camion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Camiones> ListaCamiones()
        {
            try
            {
                return _camionesRepositorio.ListaCamiones();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Camiones ActualizarCamion(Camiones camion)
        {
            try
            {
                return _camionesRepositorio.ActualizarCamion(camion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Camiones EliminarCamion(Camiones camion)
        {
            try
            {
                return _camionesRepositorio.EliminarCamion(camion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ModeloDDCamiones> DDCamiones()
        {
            try
            {
                return _camionesRepositorio.DDCamiones();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
