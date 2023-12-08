using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.Controllers
{
    [Autenticacion]
    public class RutasController : Controller
    {
        private readonly IRutasBLL _rutasBLL;

        public RutasController (IRutasBLL rutasBLL)
        {
            _rutasBLL = rutasBLL;
        }


        public ActionResult Index() 
        {
         return View();
        
        }

        public ActionResult Lista() 
        {
            return View();
        }


        public IActionResult Crear()
        {
            return View();
        }

        public IActionResult Actualizar()
        {
            return View();
        }

    }

 



}
