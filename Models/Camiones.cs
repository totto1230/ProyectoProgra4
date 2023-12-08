using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProyectoPrograCuatro.Models
{
    public class Camiones
    {
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        [DisplayName("Unidad")]
        [Required(ErrorMessage = "Ingrese la unidad")]
        public string Unidad { get; set; }

        [DisplayName("Placa")]
        [Required(ErrorMessage = "Ingrese la Placa")]
        public string Placa { get; set; }

        [DisplayName("Estado del Camión")]
        [Range(0, 1, ErrorMessage = "VALORES SOLO 1 o 0")]
        public int Estado { get; set; }
    }
}
