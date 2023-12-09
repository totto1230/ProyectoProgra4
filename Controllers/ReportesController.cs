using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;

namespace ProyectoPrograCuatro.Controllers
{
    public class ReportesController : Controller
    {
        private readonly IReporteBLL _reporteBLL;

        public ReportesController(IReporteBLL reporteBLL)
        {
            _reporteBLL = reporteBLL;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {

            try
            {
                var lista = _reporteBLL.ListarTotal(codigoCliente,  fechaInicio,  fechaFinal);
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IActionResult Filtrar(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                var lista = _reporteBLL.Filtrar( codigoCliente,fechaInicio,  fechaFinal);
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
