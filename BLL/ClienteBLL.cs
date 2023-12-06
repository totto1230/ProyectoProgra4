using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.BLL
{
    public class ClienteBLL : ICLienteBLL
    {
        private readonly IClientesRepositorio _clientesRepositorio;

       public ClienteBLL(IClientesRepositorio clientesRepositorio)
        {
            _clientesRepositorio = clientesRepositorio;
        }

        public Clientes ObtenerCliente(int idcliente)
        {
            try
            {
                return _clientesRepositorio.ObtenerCliente(idcliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertarCliente(Clientes cliente)
        {
            try
            {
                return _clientesRepositorio.InsertarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Clientes> ListaClientes()
        {
            try
            {
                return _clientesRepositorio.ListaClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        

       
    }
}
