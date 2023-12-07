using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;

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
            throw new NotImplementedException();
        }

        public List<Choferes> ListaChoferes()
        {
            throw new NotImplementedException();
        }

        public Choferes ObtenerChofer(int idchofer)
        {
            throw new NotImplementedException();
        }
    }
}
