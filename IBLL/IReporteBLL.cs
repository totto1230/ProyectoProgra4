using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IBLL
{
    public interface IReporteBLL
    {
        public List<Reporte> ListarTotal(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);

        public List<Reporte> Filtrar(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);
    }
}
