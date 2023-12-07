using Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;

namespace ProyectoPrograCuatro.Repositorios
{
    public class ChoferesRepositorio : IChoferesRepositorio
    {
        private readonly IDapperContext _dapperContext;

        public ChoferesRepositorio(IDapperContext context)
        {
            _dapperContext = context;
        }
        public Choferes ActualizarChofer(Choferes chofer)
        {
            try
            {
                var param= new DynamicParameters();
                param.Add("@Codigo", chofer.Codigo, DbType.String, ParameterDirection.Input);
                param.Add("@Nombre", chofer.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Cedula", chofer.Cedula, DbType.String, ParameterDirection.Input);
                param.Add("@Telefono", chofer.Telefono, DbType.String, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("actualizar_chofer", param, commandType: CommandType.StoredProcedure);
                    return chofer;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarChofer(int Codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarChofer(Choferes chofer)
        {
            try
            {
                var param = new DynamicParameters();
                //param.Add("@Codigo", chofer.Codigo, DbType.String, ParameterDirection.Input);
                param.Add("@Nombre", chofer.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Cedula", chofer.Cedula, DbType.String, ParameterDirection.Input);
                param.Add("@Telefono", chofer.Telefono, DbType.String, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {

                    var codigo = conn.QuerySingle<int>("insertar_chofer", param, commandType: CommandType.StoredProcedure);
                    return codigo;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Choferes> ListaChoferes()
        {
            try
            {

                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Choferes>("obtener_choferes").ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Choferes ObtenerChofer(int Codigo)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", Codigo, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var chofer= conn.QuerySingleOrDefault<Choferes>("obtener_chofer_porID", param, commandType: CommandType.StoredProcedure);

                    return chofer;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
