using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPrograCuatro.Models
{
    public class Clientes
    {
        [DisplayName("Código (ID)")]    
        public int Codigo { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string Nombre { get; set; }

        [DisplayName("Teléfono")]
        [Required(ErrorMessage = "Ingrese el teléfono del cliente")]
        public string Telefono { get; set; }


        [DisplayName("Contacto")]
        [Required(ErrorMessage = "Ingrese el contacto del cliente")]
        public string Contacto { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "Ingrese la dirección del cliente")]
        public string Direccion { get; set; }

    
        [DisplayName("Estado del Cliente")]
        [Range(0, 1, ErrorMessage = "VALORES SOLO 1 o 0")]
        public int Estado { get; set; }
    }
}
