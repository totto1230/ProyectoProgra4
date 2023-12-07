using Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;

namespace ProyectoPrograCuatro.Repositorios
{
    public class CamionesRepositorio : ICamionesRepositorio
    {

        private readonly IDapperContext _dapperContext;

            public CamionesRepositorio(IDapperContext context) 
        {
            _dapperContext = context;
        }

        public Camiones ActualizarCamion(Camiones camion)
        {
            try
            {
                var param = new DynamicParameters();
 
                param.Add("@Codigo", camion.Codigo, DbType.String, ParameterDirection.Input);
                param.Add("@Unidad", camion.Unidad, DbType.String, ParameterDirection.Input);
                param.Add("@Placa", camion.Placa, DbType.String, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("actualizar_chofer", param, commandType: CommandType.StoredProcedure);
                    return camion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarCamion(int Codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarCamion(Camiones camion)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", camion.Codigo, DbType.String, ParameterDirection.Input);
                param.Add("@Unidad", camion.Unidad, DbType.String, ParameterDirection.Input);
                param.Add("@Placa", camion.Placa, DbType.String, ParameterDirection.Input);
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

        public List<Camiones> ListaCamiones()
        {
            try
            {

                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Camiones>("obtener_camiones").ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Camiones ObtenerCamion(int Codigo)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", Codigo, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var camion = conn.QuerySingleOrDefault<Camiones>("obtener_chofer_porID", param, commandType: CommandType.StoredProcedure);

                    return camion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
