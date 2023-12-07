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

        public int EliminarCamion(int idcamion)
        {
            throw new NotImplementedException();
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

        Camiones ICamionesBLL.ActualizarCamion(Camiones camion)
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

        Camiones ICamionesBLL.ObtenerCamion(int idcamion)
        {
            try
            {
                return _camionesRepositorio.ObtenerCamion(idcamion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
