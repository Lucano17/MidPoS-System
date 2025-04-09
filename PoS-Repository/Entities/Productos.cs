

namespace PoS_Repository.Entities
{
    public class Productos
    {
        public Categorias RefCategoria { get; set; }
        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int Activo { get; set; }

    }
}
