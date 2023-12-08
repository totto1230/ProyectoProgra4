using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.Controllers
{
    [Autenticacion]
    public class ClientesController : Controller
    {
        private readonly ICLienteBLL _clienteBLL;

        public ClientesController(ICLienteBLL clienteBLL)
        {
            _clienteBLL = clienteBLL;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {

            try
            {
                var lista = _clienteBLL.ListaClientes();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //muestra la vista de clientes vacia para poder insertar un cliente
        //HTTPGET va del servidor al cliente
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Clientes cliente)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var codigo = _clienteBLL.InsertarCliente(cliente);
                ViewBag.Message = "Cliente creado con exito con codigo: " + codigo.ToString();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //HTTPGET devuelve datos del servidor al cliente en base al id del cliente
        public IActionResult Actualizar(int idcliente)
        {
            try
            {
                var cliente = _clienteBLL.ObtenerCliente(idcliente);
                if (cliente==null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(cliente);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpPost]
        public IActionResult Actualizar(Clientes cliente)
        {
            try
            {
                var cliente_updated = _clienteBLL.ActualizarCliente(cliente);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Eliminar(int idcliente)
        {
            try
            {
                var cliente = _clienteBLL.ObtenerCliente(idcliente);
                if (cliente == null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(cliente);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


        [HttpPost]
        public IActionResult Eliminar(Clientes cliente)
        {
            try
            {
                var cliente_updated = _clienteBLL.EliminarCliente(cliente);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
