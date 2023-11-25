using Progra4BD.BLL;
using Progra4BD.Models;

namespace Progra4BD.IRepositorios
{
    public interface IClientesRepositorio
    {
        public List<Cliente> ListaClientes();
        public int InsertarCliente(Cliente cliente);
        public Cliente ObtenerCliente(int idcliente);
    


    }
}
