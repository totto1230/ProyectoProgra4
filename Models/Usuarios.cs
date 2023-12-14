using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;

namespace ProyectoPrograCuatro.Models
{
    // Clase que representa la entidad de usuarios en el sistema
    public class Usuarios
    {

        // Atributo para el Código(ID) del usuario, se usa[ValidateNever] para no validar en el modelo
        [ValidateNever]
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        // Atributo para el Nombre del usuario, se agrega [ValidateNever] para evitar su validación en el modelo
        // Se agrega [Required] para especificar que este campo es obligatorio y se define el mensaje de error si no se proporciona
        [ValidateNever]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string Nombre { get; set; }

        // Atributo para el nombre de Usuario, se agrega [Required] para especificar que este campo es obligatorio
        // y se define el mensaje de error si no se proporciona
        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Ingrese el usuario")]
        public string Usuario { get; set; }

        // Atributo para la contraseña del usuario, se agrega [Required] para especificar que este campo es obligatorio
        // y se define el mensaje de error si no se proporciona
        // Se usa [DataType(DataType.Password)] para indicar al navegador que este campo representa una contraseña
        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Ingrese la contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        // Atributo para el estado del usuario, se usa [ValidateNever] para no validar en el modelo
        // Se agrega [Range] para definir un rango de valores permitidos (0 y 1)
        [ValidateNever]
        [DisplayName("Estado del Usuario")]
        [Range(0,1, ErrorMessage = "VALORES SOLO 1 o 0")]
        public int Estado { get; set; }

    }
}
