﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProyectoPrograCuatro.Models
{
    public class Usuarios
    {
        [ValidateNever]
        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        [ValidateNever]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        public string Nombre { get; set; }

        [DisplayName("Usuario/User")]
        [Required(ErrorMessage = "Ingrese el usuario")]
        public string Usuario { get; set; }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Ingrese la contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }
        

    }
}
