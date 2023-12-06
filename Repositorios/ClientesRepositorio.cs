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

        public Clientes ObtenerCliente(int idcliente)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Id", idcliente, DbType.Int32, ParameterDirection.Input);
                using(var conn = _dapperContext.CrearConexion())
                {
                    var cliente = conn.QuerySingleOrDefault<Clientes>("obtener_cliente_porID", param, commandType: CommandType.StoredProcedure);
                    
                    return cliente;
                }
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

        public List<Clientes> ListaClientes()
        {
            try
            {
               
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Clientes>("obtener_clientes").ToList();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
