
using System.ComponentModel;

namespace PoS_Presentation.ViewModels
{
    public class ReporteVentaViewModel
    {
        [DisplayName("Nro de Venta")]
        public string NumeroVenta { get; set; }

        [DisplayName("Nombre de usuario")]
        public string NombreUsuario { get; set; }

        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; }

        public string Producto { get; set; }

        [DisplayName("Prec. Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Prec. Venta")]
        public decimal PrecioVenta { get; set; }

        public int Cantidad { get; set; }

        [DisplayName("Prec. Total")]
        public decimal PrecioTotal { get; set; }

    }
}
