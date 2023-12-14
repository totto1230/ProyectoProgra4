using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using ProyectoPrograCuatro.Login;

namespace ProyectoPrograCuatro.Controllers
{
    [Autenticacion]
    public class ReportesController : Controller
    {
        private readonly IReporteBLL _reporteBLL;
        private readonly ICLienteBLL _cLienteBLL;

        public ReportesController(IReporteBLL reporteBLL, ICLienteBLL cLienteBLL)
        {
            _reporteBLL = reporteBLL;
            _cLienteBLL = cLienteBLL;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        {

            try
            {
                ViewBag.Clientes = _cLienteBLL.DDClientes();
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
                ViewBag.Clientes = _cLienteBLL.DDClientes();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
