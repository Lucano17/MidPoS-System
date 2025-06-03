
using System.ComponentModel;

namespace PoS_Presentation.ViewModels
{
    public class VentaViewModel
    {
        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; }
        public string NumeroVenta { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
    }
}
