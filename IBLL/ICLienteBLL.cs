using Progra4BD.Models;

namespace Progra4BD.IBLL
{
    public interface ICLienteBLL
    {
        public List<Clientes> ListaClientes();
        public int InsertarCliente(Clientes cliente);
        public Clientes ObtenerCliente(int idcliente);
    
       

    }
}
