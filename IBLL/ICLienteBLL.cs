using Progra4BD.Models;

namespace Progra4BD.IBLL
{
    public interface ICLienteBLL
    {
        public List<Cliente> ListaClientes();
        public int InsertarCliente(Cliente cliente);
        public Cliente ObtenerCliente(int idcliente);
    
       

    }
}
