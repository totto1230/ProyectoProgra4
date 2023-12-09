using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios

{
    public interface IReporteRepositorio
    {
        public List<Reporte> ListarTotal(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);

        public List<Reporte> Filtrar(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal);
    }
}
