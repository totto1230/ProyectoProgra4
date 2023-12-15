﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;
using System.Collections.Generic;
using System.Globalization;

namespace ProyectoPrograCuatro.Controllers
{
    [Autenticacion]

    // Constructor que recibe instancias de las interfaces necesarias
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

        // Acción por defecto que muestra la vista Index
        public ActionResult Index() 
        {
         return View();
        
        }
        // Acción que muestra una lista de rutas
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

        // Acción para crear una nueva ruta (GET)
        public IActionResult Crear()
        {
            // Obtener listas de clientes, choferes y camiones
            ViewBag.Clientes = _cLienteBLL.DDClientes();
            ViewBag.Choferes = _choferesBLL.DDChoferes();
            ViewBag.Camiones = _camionesBLL.DDCamiones();

            // Establecer la fecha actual si no está definida en el modelo
            var modelo = new Rutas();
            if (modelo.FechaCreacion == null)
            {
                modelo.FechaCreacion = DateTime.Now;
            }
            return View(modelo);

        }

        // Acción para crear una nueva ruta (POST)
        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Rutas ruta)
        {

            try
            {
                ViewBag.Clientes = _cLienteBLL.DDClientes();
                ViewBag.Choferes = _choferesBLL.DDChoferes();
                ViewBag.Camiones = _camionesBLL.DDCamiones();

                // Validar el modelo
                if (!ModelState.IsValid)
                {
                    // Si el modelo no es válido, devolver la vista de creación con los errores
                    ViewBag.Clientes = _cLienteBLL.DDClientes();
                    ViewBag.Choferes = _choferesBLL.DDChoferes();
                    ViewBag.Camiones = _camionesBLL.DDCamiones();
                    return View();
                }

                // Insertar la ruta utilizando el servicio BLL
                var codigo = _rutasBLL.InsertarRuta(ruta);
                ViewBag.Message = "Ruta creada con éxito con código: " + codigo.ToString();
                return RedirectToAction("Lista", "Rutas"); // Puedes redirigir a una vista de éxito o a donde sea necesario
            }
            catch (Exception ex)
            {
                // Manejar excepciones si ocurre algún error
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

                // Obtener la lista actualizada después de la actualización
                var listaActualizada = _rutasBLL.ListaRutas();

                // Pasar la lista actualizada a la vista Lista
                return View("Lista", listaActualizada);
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
