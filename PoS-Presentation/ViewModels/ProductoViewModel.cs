

using System.ComponentModel;

namespace PoS_Presentation.ViewModels
{
    public class ProductoViewModel
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }

        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Precio Venta")]
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int Activo { get; set; }
        public string Habilitado { get; set; }
    }
}
