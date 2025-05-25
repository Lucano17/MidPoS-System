
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PoS_Repository.Entities
{
    public class DetalleVenta
    {
        public int Id_DetalleVenta { get; set; }
        public int Id_Venta { get; set; }
        public Venta RefVenta { get; set; }
        //public int Id_Producto { get; set; }
        public Productos RefProducto { get; set; }
        //public int Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
