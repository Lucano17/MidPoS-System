
using System.ComponentModel;

namespace PoS_Presentation.ViewModels
{
    public class DetalleVentaViewModel
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int CantidadValor { get; set; }

        [DisplayName("Cantidad")]
        public string CantidadTexto { get; set; }
        public decimal Total { get; set; }
    }
}
