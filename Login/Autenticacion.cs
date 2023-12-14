using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace ProyectoPrograCuatro.Login
{
    // Filtro de acción para verificar la autenticación del usuario
    public class Autenticacion : ActionFilterAttribute
    {
        // Método que se ejecuta antes de que se ejecute una acción del controlador
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Verifica si el usuario ha iniciado sesión (utilizando, por ejemplo, una variable de sesión "Usuario")
            if (filterContext.HttpContext.Session.GetString("Usuario") == null)
            {
                // Si el usuario no ha iniciado sesión, redirige a la acción "Login" del controlador "Usuarios"
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                                { "Controller", "Usuarios" },
                                { "Action", "Login" }
                            });
            }
        }
        }
    }
