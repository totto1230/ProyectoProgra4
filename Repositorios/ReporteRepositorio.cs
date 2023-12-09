using Dapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;

namespace ProyectoPrograCuatro.Repositorios
{
    public class ReporteRepositorio : IReporteRepositorio
    {
        private readonly IDapperContext _dapperContext;

        //Constructor para instanciar la variable
        public ReporteRepositorio(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public List<Reporte> Filtrar(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@FechaInicio", fechaInicio, DbType.DateTime, ParameterDirection.Input);
                param.Add("@FechaFinal", fechaFinal, DbType.DateTime, ParameterDirection.Input);
                param.Add("@Cliente", codigoCliente, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Reporte>("obtener_reporte_rutas", param).ToList();
                  
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reporte> ListarTotal(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {
			try
			{
                using (var conn = _dapperContext.CrearConexion())
                {
                   return conn.Query<Reporte>("obtener_todos_reportes").ToList();
                }
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
