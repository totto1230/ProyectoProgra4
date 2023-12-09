﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly ICLienteBLL _cLienteBLL;
        private readonly IChoferesBLL _choferesBLL;
        private readonly ICamionesBLL _camionesBLL;

        public RutasController (ICLienteBLL clienteBLL,IChoferesBLL choferesBLL, ICamionesBLL camionesBLL, IRutasBLL rutasBLL)
        {
            _cLienteBLL = clienteBLL;
            _choferesBLL = choferesBLL;
            _camionesBLL = camionesBLL;
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
            ViewBag.Clientes = _cLienteBLL.DDClientes();
            ViewBag.Choferes = _choferesBLL.DDChoferes();
            ViewBag.Camiones = _camionesBLL.DDCamiones();
            return View();
        }


        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Rutas ruta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Obtener la fecha actual
                    ruta.FechaCreacion = DateTime.Now;

                    // Llamar al método InsertarRuta del BLL y pasar la ruta
                    var codigo = _rutasBLL.InsertarRuta(ruta);

                    ViewBag.Message = "Ruta creada con éxito con código: " + codigo.ToString();
                    return View(); // Puedes redirigir a una vista de éxito o a donde sea necesario
                }

    

                return View(ruta);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocurrió un error al crear la ruta: " + ex.Message;
                return View(ruta); // Puedes redirigir a una vista de error o a donde sea necesario
            }
        }



        public IActionResult Actualizar(int codigoruta) 
        {

            try
            {
                var ruta = _rutasBLL.ObtenerRuta(codigoruta);
                if (ruta == null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(ruta);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public IActionResult Actualizar(Rutas ruta)
        {
            try
            {
                var cliente_updated = _rutasBLL.ActualizarRuta(ruta);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {

                throw;
            }
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
