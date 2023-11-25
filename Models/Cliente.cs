using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Progra4BD.Models
{
    public class Cliente
    {
        [DisplayName("Código")]    
        public int id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string nombre { get; set; }
        [DisplayName("Teléfono")]
        [Required(ErrorMessage = "Ingrese el teléfono del cliente")]
        public string telefono { get; set; }
        [DisplayName("Contacto")]
        [Required(ErrorMessage = "Ingrese el contacto del cliente")]
        public string contacto { get; set; }

    }
}
