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

        //public Rutas GenerarReporte(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        //{
        //    try
        //    {
        //        var param = new DynamicParameters();
        //        param.Add("@CodigoCliente", codigoCliente , DbType.Int32, ParameterDirection.Input);
        //        param.Add("@FechaInicio", fechaInicio, DbType.DateTime, ParameterDirection.Input);
        //        param.Add("@FechaFinal", fechaFinal, DbType.DateTime, ParameterDirection.Input);
        //        using (var conn = _dapperContext.CrearConexion())
        //        {
        //            var reporte = conn.QuerySingleOrDefault<Rutas>("obtener_reporte_rutas", param, commandType: CommandType.StoredProcedure);
        //            return reporte;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

 

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

        public Rutas ObtenerRuta(int codigoruta)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", codigoruta, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var ruta = conn.QuerySingleOrDefault<Rutas>("obtener_cliente_porID", param, commandType: CommandType.StoredProcedure);

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
