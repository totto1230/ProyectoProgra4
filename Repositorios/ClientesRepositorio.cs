using Dapper;
using Progra4BD.IDapper;
using Progra4BD.IRepositorios;
using Progra4BD.Models;
using System.Data;

namespace Progra4BD.Repositorios
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly IDapperContext _dapperContext;

        public ClientesRepositorio(IDapperContext context)
        {
            _dapperContext = context;
        }

        public Cliente ObtenerCliente(int idcliente)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Id", idcliente, DbType.Int32, ParameterDirection.Input);
                using(var conn = _dapperContext.CrearConexion())
                {
                    var cliente = conn.QuerySingleOrDefault<Cliente>("obtener_cliente_porID", param, commandType: CommandType.StoredProcedure);
                    
                    return cliente;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertarCliente(Cliente cliente)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@nombre", cliente.nombre, DbType.String, ParameterDirection.Input);
                param.Add("@telefono", cliente.telefono, DbType.String, ParameterDirection.Input);
                param.Add("@contacto", cliente.contacto, DbType.String, ParameterDirection.Input);
                using(var conn = _dapperContext.CrearConexion())
                {

                    var id = conn.QuerySingle<int>("insertar_cliente", param, commandType: CommandType.StoredProcedure);
                    return id;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Cliente> ListaClientes()
        {
            try
            {
               
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Cliente>("obtener_clientes").ToList();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
