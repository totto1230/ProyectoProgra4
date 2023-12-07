using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPrograCuatro.Models
{
    public class Choferes
    {
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del chofer")]
        public string Nombre { get; set; }

        [DisplayName("Cédula")]
        [Required(ErrorMessage = "Ingrese la cédula")]
        public string Cedula { get; set; }

        [DisplayName("Télefono")]
        [Required(ErrorMessage = "Ingrese Télefono")]
        public string Telefono { get; set; }

        [DisplayName("Chofer Válido?")]
        public int Estado { get; set; }
    }
}
