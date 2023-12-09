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

            try
            {
                var lista = _rutasBLL.ListaRutas();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public IActionResult Crear()
        {
            Rutas nuevaRuta = new Rutas
            {
                
                FechaCreacion = DateTime.Now 
            };

            return View(nuevaRuta);
        }


        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Rutas ruta)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var codigo = _rutasBLL.InsertarRuta(ruta);
                ViewBag.Message = "Cliente creado con exito con codigo: " + codigo.ToString();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult Actualizar()
        {
            return View();
        }

        //public IActionResult Reporte(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal) 
        //{
        //    try
        //    {
        //        var reporte = _rutasBLL.GenerarReporte(codigoCliente, fechaInicio, fechaFinal);
        //        return View(reporte);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }

 }
