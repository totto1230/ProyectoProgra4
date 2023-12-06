using Progra4BD.BLL;
using Progra4BD.Models;

namespace Progra4BD.IRepositorios
{
    public interface IClientesRepositorio
    {
        public List<Clientes> ListaClientes();
        public int InsertarCliente(Clientes cliente);
        public Clientes ObtenerCliente(int idcliente);

        public Clientes ActualizarCliente(Clientes cliente);
        public int EliminarCliente(int idcliente);

    }
}
