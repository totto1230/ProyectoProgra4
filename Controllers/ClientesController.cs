using Microsoft.AspNetCore.Mvc;
using Progra4BD.IBLL;
using Progra4BD.Models;

namespace Progra4BD.Controllers
{
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
        public IActionResult Crear(Cliente cliente)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var id = _clienteBLL.InsertarCliente(cliente);
                ViewBag.Message = "Cliente creado con exito con codigo: " + id.ToString();
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

        
        
    }
}
