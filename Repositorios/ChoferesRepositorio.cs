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
            throw new NotImplementedException();
        }

        public List<Choferes> ListaChoferes()
        {
            throw new NotImplementedException();
        }

        public Choferes ObtenerChofer(int Codigo)
        {
            throw new NotImplementedException();
        }
    }
}
