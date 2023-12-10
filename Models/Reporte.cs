namespace ProyectoPrograCuatro.Models
{
    public class Reporte
    {
        public int Codigo { get; set; }

        public int CodigoClientes { get; set; }

        public String? NombreCliente { get; set; }

        public int CodigoChoferes { get; set; }

        public int CodigoCamiones { get; set; }

        public String? DireccionEntrega { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaFinal { get; set; }

        public int Estado { get; set; }
    }
}
