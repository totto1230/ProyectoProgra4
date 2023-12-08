using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.Login;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuariosBLL _usuariosBLL;

        public UsuariosController(IUsuariosBLL usuariosBLL)
        {
            _usuariosBLL = usuariosBLL;
        }

        public IActionResult Index() { 
        
            return View();
        }
        
        //UTILIZA HTTP GET para validar si hay una sesion

        public IActionResult Login()
        {
            //Si no tiene sesión enseñe el login
            if (HttpContext.Session.GetString("Usuario")==null)
            {
                return View();
            }
            else
            {
                //Si tiene sesion, enseñe el index
                return RedirectToAction("Index", "Home");
            }
            

        }

        //Tenemos que especificar el metodo HTTP POST ya que va a crear la sesion
        [HttpPost]
        public IActionResult Login (Usuarios usuarios)
        {
            try
            {
                //VALIDA QUE EL USUARIO ESTE BIEN
                if (ModelState.IsValid)
                {
                    if (_usuariosBLL.ValidarUsuario(usuarios) != null)
                    {
                        HttpContext.Session.SetString("Usuario", usuarios.Usuario);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Message = "USUARIO INVALIDO";
                        return View();
                    }
                }
                else 
                {
                    return View();
                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        //METODO PARA DESLOGUEARSE
        public IActionResult LogOut()
        {
            // limpia sesiones
            HttpContext.Session.Clear();
            // remueve la sesion del usuario
            HttpContext.Session.Remove("Usuario");
            // se redirecciona a la vista de Login llando a su Action
            return RedirectToAction("Login");
        }

        [Autenticacion]
        public IActionResult Lista()
        {
            try
            {
                var lista = _usuariosBLL.ListaUsuarios();
                return View(lista);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Autenticacion]
        public IActionResult Crear()
        {
            return View();
        }

        [Autenticacion]
        [HttpPost] //del cliente al servidor
        public IActionResult Crear(Usuarios usuarios)
        {
            try
            {
                //valida si todos los campos requeridos tienen datos
                if (!ModelState.IsValid)
                {
                    //devuelve la vista y muestra los mensajes de error
                    return View();
                }

                var id = _usuariosBLL.InsertarUsuario(usuarios);
                ViewBag.Message = "Usuario creado con exito con codigo: " + id.ToString();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Autenticacion]
        //HTTPGET devuelve datos del servidor al cliente en base al id del cliente
        public IActionResult Actualizar(int idUsuario)
        {
            try
            {
                var usuario = _usuariosBLL.ObtenerUsuario(idUsuario);
                if (usuario == null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(usuario);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        [Autenticacion]
        // Esta accion se ejecuta al presionar el boton de 
        //Actualizar
        [HttpPost]
        public IActionResult Actualizar(Usuarios usuarios)
        {
            try
            {
                var usuarioactualizado = _usuariosBLL.ActualizarUsuario(usuarios);
                //redirecciona a la accion Lista
                //esta acción esta creada como primer método del controller
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                //devolver el mensaje de error
                //Y se queda en la vista de actualizar
                ViewBag.Message = "Error al actualizar el usuario";
                return View();
            }
        }

        [Autenticacion]
        //HTTPGET devuelve datos del servidor al cliente en base al id del cliente
        public IActionResult Eliminar(int idUsuario)
        {
            try
            {
                var usuario = _usuariosBLL.ObtenerUsuario(idUsuario);
                if (usuario == null)//si no se encontró datos del cliente
                {
                    return View();
                }
                else
                {
                    return View(usuario);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        [Autenticacion]
        // Esta accion se ejecuta al presionar el boton de 
        //Actualizar
        [HttpPost]
        public IActionResult Eliminar(Usuarios usuarios)
        {
            try
            {
                var usuarioeliminado = _usuariosBLL.EliminarUsuario(usuarios);
                //redirecciona a la accion Lista
                //esta acción esta creada como primer método del controller
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                //devolver el mensaje de error
                //Y se queda en la vista de actualizar
                ViewBag.Message = "Error al actualizar el usuario";
                return View();
            }
        }
    }
}
