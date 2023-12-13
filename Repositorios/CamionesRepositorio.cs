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
 

        public Camiones ObtenerCamion(int codigoCamion)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", codigoCamion, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var camion = conn.QuerySingleOrDefault<Camiones>("obtener_camiones_porID", param, commandType: CommandType.StoredProcedure);

                    return camion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertarCamion(Camiones camion)
        {
            try
            {
                var param = new DynamicParameters();
                //param.Add("@Codigo", camion.Codigo, DbType.String, ParameterDirection.Input);
                param.Add("@Unidad", camion.Unidad, DbType.String, ParameterDirection.Input);
                param.Add("@Placa", camion.Placa, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", camion.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {

                    var codigo = conn.QuerySingle<int>("insertar_camiones", param, commandType: CommandType.StoredProcedure);
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


        public Camiones ActualizarCamion(Camiones camion)
        {
            try
            {
                var param = new DynamicParameters();
 
                param.Add("@Codigo", camion.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Unidad", camion.Unidad, DbType.String, ParameterDirection.Input);
                param.Add("@Placa", camion.Placa, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", camion.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("actualizar_camiones", param, commandType: CommandType.StoredProcedure);
                    return camion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Camiones EliminarCamion(Camiones camion)
        {
            try
            {
                var param = new DynamicParameters();

                param.Add("@Codigo", camion.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Estado", 0, DbType.String, ParameterDirection.Input);

                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("eliminar_camiones", param, commandType: CommandType.StoredProcedure);
                    return camion;
                }
               

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ModeloDDCamiones> DDCamiones()
        {
            try
            {
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<ModeloDDCamiones>("carga_dropdown_camiones").ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
