using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProyectoPrograCuatro.Models
{
    public class Usuarios
    {
        [ValidateNever]
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        //Necesario para que el login no espere algo en el nombre
        [ValidateNever]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string Nombre { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Ingrese el usuario")]
        public string Usuario { get; set; }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Ingrese la contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        [ValidateNever]
        [DisplayName("Estado del Usuario")]
        [Range(0,1, ErrorMessage = "VALORES SOLO 1 o 0")]
        public int Estado { get; set; }

    }
}
