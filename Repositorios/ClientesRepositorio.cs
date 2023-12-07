using Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;

namespace ProyectoPrograCuatro.Repositorios
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
                param.Add("@Codigo", idcliente, DbType.Int32, ParameterDirection.Input);
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
                param.Add("@Nombre", cliente.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Telefono", cliente.Telefono, DbType.String, ParameterDirection.Input);
                param.Add("@Contacto", cliente.Contacto, DbType.String, ParameterDirection.Input);
                param.Add("@Direccion", cliente.Direccion, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", cliente.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {

                    var codigo = conn.QuerySingle<int>("insertar_cliente", param, commandType: CommandType.StoredProcedure);
                    return codigo;

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

        public Clientes ActualizarCliente(Clientes cliente)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", cliente.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Nombre", cliente.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Telefono", cliente.Telefono, DbType.String, ParameterDirection.Input);
                param.Add("@Contacto", cliente.Contacto, DbType.String, ParameterDirection.Input);
                param.Add("@Direccion", cliente.Direccion, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", cliente.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("actualizar_cliente", param, commandType: CommandType.StoredProcedure);
                    return cliente;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarCliente(int idcliente)
        {
            throw new NotImplementedException();
        }
    }
}
