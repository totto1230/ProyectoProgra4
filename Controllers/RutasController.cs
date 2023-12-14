﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;
using System.Globalization;

namespace ProyectoPrograCuatro.Controllers
{
    //[Autenticacion]
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

            //PARA IMPRIMIR Y ESTABLECER LA FECHA
            var modelo = new Rutas();
            if (modelo.FechaCreacion == null)
            {
                modelo.FechaCreacion = DateTime.Now;
            }
            return View(modelo);

        }


        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Rutas ruta)
        {

            try
            {
                ViewBag.Clientes = _cLienteBLL.DDClientes();
                ViewBag.Choferes = _choferesBLL.DDChoferes();
                ViewBag.Camiones = _camionesBLL.DDCamiones();
                if (!ModelState.IsValid)
                {
                    ViewBag.Clientes = _cLienteBLL.DDClientes();
                    ViewBag.Choferes = _choferesBLL.DDChoferes();
                    ViewBag.Camiones = _camionesBLL.DDCamiones();
                    return View();
                }

                var codigo = _rutasBLL.InsertarRuta(ruta);
                ViewBag.Message = "Ruta creada con éxito con código: " + codigo.ToString();
                return RedirectToAction("Lista", "Rutas"); // Puedes redirigir a una vista de éxito o a donde sea necesario
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocurrió un error al crear la ruta: " + ex.Message;
                return View(ruta); // Puedes redirigir a una vista de error o a donde sea necesario
            }
        }



        public IActionResult Actualizar(int codigoRuta) 
        {
            try
            {
                var ruta = _rutasBLL.ObtenerRuta(codigoRuta);

                // Verificar si la ruta existe
                if (ruta == null)
                {
                    return View();
                }
                else
                {
                    // Establecer la fecha y hora actual antes de mostrar la vista
                    ruta.FechaCreacion = DateTime.Now;

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
                ViewBag.Clientes = _cLienteBLL.DDClientes();
                ViewBag.Choferes = _choferesBLL.DDChoferes();
                ViewBag.Camiones = _camionesBLL.DDCamiones();
                var rutaActualizada = _rutasBLL.ActualizarRuta(ruta);
                //var listaActualizada = _rutasBLL.ListaRutas(); // Obtener la lista actualizada después de la actualización
                return RedirectToAction("Lista", "Rutas"); // Devolver la vista Lista con los datos actualizados
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si es necesario
                ViewBag.ErrorMessage = "Ocurrió un error al actualizar la ruta: " + ex.Message;
                return View("Error"); // Redirigir a una vista de error en caso de excepción
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
