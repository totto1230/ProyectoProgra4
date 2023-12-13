using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IBLL
{
    public interface ICLienteBLL
    {
        public List<Clientes> ListaClientes();
        public int InsertarCliente(Clientes cliente);
        public Clientes ObtenerCliente(int idcliente);
        public Clientes ActualizarCliente(Clientes cliente);

        public Clientes EliminarCliente(Clientes cliente);

        public List<ModeloDDClientes> DDClientes();
    }
}
