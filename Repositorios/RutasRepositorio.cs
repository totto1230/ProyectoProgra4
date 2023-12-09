using Dapper;
using ProyectoPrograCuatro.Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;


namespace ProyectoPrograCuatro.Repositorios
{
    public class RutasRepositorio : IRutasRepositorio
    {

        private readonly IDapperContext _dapperContext;

        public RutasRepositorio (IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public int InsertarRuta(Rutas ruta)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@CodigoCliente", ruta.CodigoCliente, DbType.Int32, ParameterDirection.Input);
                param.Add("@CodigoChofer", ruta.CodigoChofer, DbType.Int32, ParameterDirection.Input);
                param.Add("@CodigoCamion", ruta.CodigoCamion, DbType.Int32, ParameterDirection.Input);
                param.Add("@DireccionEntrega", ruta.DireccionEntrega, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", ruta.Estado, DbType.String, ParameterDirection.Input);
                param.Add("@FechaCreacion", DateTime.Now, DbType.DateTime, ParameterDirection.Input);

                using (var conn = _dapperContext.CrearConexion())
                {
                    var codigo = conn.QuerySingle<int>("insertar_ruta", param, commandType: CommandType.StoredProcedure);
                    return codigo;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<Rutas> ListaRutas()
        {
            try
            {

                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Rutas>("obtener_rutas").ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Camiones> ObtenerCamionesDisponibles()
        {
            try
            {
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Camiones>("obtener_camiones_disponibles").ToList();
                    // Reemplaza "obtener_camiones_disponibles" por el nombre correcto de tu procedimiento almacenado o consulta SQL para obtener camiones disponibles
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Choferes> ObtenerChoferesDisponibles()
        {
            try
            {
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Choferes>("obtener_choferes_disponibles").ToList();
                    // Reemplaza "obtener_choferes_disponibles" por el nombre correcto de tu procedimiento almacenado o consulta SQL para obtener choferes disponibles
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Clientes> ObtenerClientesDisponibles()
        {
            try
            {
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Clientes>("obtener_clientes_disponibles").ToList();
                    // Reemplaza "obtener_clientes_disponibles" por el nombre correcto de tu procedimiento almacenado o consulta SQL para obtener clientes disponibles
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Rutas ObtenerRuta(int codigoruta)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", codigoruta, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var ruta = conn.QuerySingleOrDefault<Rutas>("obtener_ruta_porID", param, commandType: CommandType.StoredProcedure);

                    return ruta;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
