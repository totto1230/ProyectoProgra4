using Progra4BD.IBLL;
using Progra4BD.IRepositorios;
using Progra4BD.Models;

namespace Progra4BD.BLL
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
