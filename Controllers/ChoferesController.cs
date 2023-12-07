using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.Controllers
{

    [Autenticacion]
    public class ChoferesController : Controller
    {
        private readonly IChoferesBLL _choferesBLL;

        public ChoferesController(IChoferesBLL choferesBLL)
        {
            _choferesBLL = choferesBLL;
        }   

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Actualizar(int idchofer)
        {
            try
            {
                var chofer = _choferesBLL.ObtenerChofer(idchofer);
                if (chofer == null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(chofer);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        // Esta accion se ejecuta al presionar el boton de 
        //Actualizar
        [HttpPost]
        public IActionResult Actualizar(Choferes chofer)
        {
            try
            {
                var clienteactualizado = _choferesBLL.ActualizarChofer(chofer);
                //redirecciona a la accion Lista
                //esta acción esta creada como primer método del controller
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                //devolver el mensaje de error
                //Y se queda en la vista de actualizar
                ViewBag.Message = "Error al actualizar el cliente";
                return View();
            }
        }

    }
}
