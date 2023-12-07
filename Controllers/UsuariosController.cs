using Microsoft.AspNetCore.Mvc;
using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.IBLL;
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

    }
}
