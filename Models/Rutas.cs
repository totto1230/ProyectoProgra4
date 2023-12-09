﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProyectoPrograCuatro.Models
{
    public class Rutas
    {

        [DisplayName("Código (ID)")]
        public int Codigo { get; set; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "Seleccione el cliente")]
        public int CodigoCliente { get; set; }
        [ValidateNever]

        [DisplayName("Chofer")]
        [Required(ErrorMessage = "Seleccione el chofer")]
        public int CodigoChofer { get; set; }
        [ValidateNever]

        [DisplayName("Camión")]
        [Required(ErrorMessage = "Seleccione el camión")]
        public int CodigoCamion { get; set; }
        [ValidateNever]


        [DisplayName("Dirección de Entrega")]
        [Required(ErrorMessage = "Ingrese la dirección de entrega")]
        public string DireccionEntrega { get; set; }

        [DisplayName("Fecha de creacion")]
        [Required(ErrorMessage = "Ingrese la fecha")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Estado de la Ruta")]
        [Required(ErrorMessage = "Ingrese el estado")]
        [Range(0, 1, ErrorMessage = "VALORES SOLO 1 o 0")]
        public int Estado { get; set; }
    }
}
