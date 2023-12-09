using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using ProyectoPrograCuatro.Repositorios;

namespace ProyectoPrograCuatro.BLL
{
    public class ReporteBLL : IReporteBLL
    {
        private readonly IReporteRepositorio _reporteRepositorio;

        public ReporteBLL(IReporteRepositorio clientesRepositorio)
        {
            _reporteRepositorio = clientesRepositorio;
        }

        public List<Reporte> ListarTotal(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {
			try
			{
                return _reporteRepositorio.ListarTotal(codigoCliente, fechaInicio, fechaFinal);
			}
			catch (Exception)
			{

				throw;
			}
        }

        public List<Reporte> Filtrar(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                return _reporteRepositorio.Filtrar(codigoCliente, fechaInicio, fechaFinal);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
