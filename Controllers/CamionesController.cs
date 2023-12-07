using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;


namespace ProyectoPrograCuatro.Controllers
{
    [Autenticacion]
    public class CamionesController : Controller
    {
        private readonly ICamionesBLL _camionesBLL;
        
        public  CamionesController (ICamionesBLL camionesBLL)
        {
            _camionesBLL = camionesBLL;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            try
            {
                var lista = _camionesBLL.ListaCamiones();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult crear()
        {
            return View();
        }

        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Camiones camion)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var codigo = _camionesBLL.InsertarCamion(camion);
                ViewBag.Message = "Camion creado con exito con codigo: " + codigo.ToString();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Actualizar(int idcamion)
        {
            try
            {
                var chofer = _camionesBLL.ObtenerCamion(idcamion);
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
        public IActionResult Actualizar(Camiones camion)
        {
            try
            {
                var clienteactualizado = _camionesBLL.ActualizarCamion(camion);
                //redirecciona a la accion Lista
                //esta acción esta creada como primer método del controller
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                //devolver el mensaje de error
                //Y se queda en la vista de actualizar
                ViewBag.Message = "Error al actualizar el camion";
                return View();
            }
        }

    }
}
