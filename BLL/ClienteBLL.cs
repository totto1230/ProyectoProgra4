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

        public Clientes ActualizarCliente(Clientes cliente)
        {
            try
            {
                return _clientesRepositorio.ActualizarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Clientes EliminarCliente(Clientes cliente)
        {
            try
            {
                return _clientesRepositorio.EliminarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ModeloDDClientes> DDClientes()
        {
            try
            {
                return _clientesRepositorio.DDClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
