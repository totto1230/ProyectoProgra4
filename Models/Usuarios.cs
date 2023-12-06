using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProyectoPrograCuatro.Models
{
    public class Usuarios
    {
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string Nombre { get; set; }

        [DisplayName("Usuario/User")]
        [Required(ErrorMessage = "Ingrese el usuario")]
        public string Usuario { get; set; }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Ingrese la contraseña")]
        public string Contrasenia { get; set; }

    }
}
