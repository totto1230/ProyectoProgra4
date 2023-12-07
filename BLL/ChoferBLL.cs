using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using ProyectoPrograCuatro.Repositorios;

namespace ProyectoPrograCuatro.BLL
{
    public class ChoferBLL : IChoferesBLL
    {
        private readonly IChoferesRepositorio _choferRepositorio;

        public ChoferBLL(IChoferesRepositorio choferRepositorio)
        {
            _choferRepositorio = choferRepositorio;
        }

        public Choferes ActualizarChofer(Choferes chofer)
        {
            try
            {
                return _choferRepositorio.ActualizarChofer(chofer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarChofer(int idchofer)
        {
            throw new NotImplementedException();
        }

        public int InsertarChofer(Choferes chofer)
        {
            try
            {
                return _choferRepositorio.InsertarChofer(chofer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Choferes> ListaChoferes()
        {
            try
            {
                return _choferRepositorio.ListaChoferes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Choferes ObtenerChofer(int idchofer)
        {
            try
            {
                return _choferRepositorio.ObtenerChofer(idchofer);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
