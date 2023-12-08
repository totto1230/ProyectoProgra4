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

        public IActionResult Lista() 
        {

            try
            {
                var lista = _choferesBLL.ListaChoferes();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Crear() 
        {
            return View();
        }

        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Choferes chofer)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var codigo = _choferesBLL.InsertarChofer(chofer);
                ViewBag.Message = "Chofer creado con exito con codigo: " + codigo.ToString();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Eliminar(int idchofer)
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


        [HttpPost]
        public IActionResult Eliminar(Choferes chofer)
        {
            try
            {
                var chofer_eliminado = _choferesBLL.EliminarChofer(chofer);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
