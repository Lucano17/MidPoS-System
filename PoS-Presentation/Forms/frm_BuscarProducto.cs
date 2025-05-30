using PoS_Presentation.Utilities;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;

namespace PoS_Presentation.Forms
{
    public partial class frm_BuscarProducto : Form
    {
        private readonly IProductoService _productoService;
        public ProductoViewModel _productoSeleccionado { get; set; } = null!;
        public frm_BuscarProducto(IProductoService productoService)
        {
            InitializeComponent();
            _productoService = productoService;
        }

        private async void frm_BuscarProducto_Load(object sender, EventArgs e)
        {
            ProductosDGV.ImplementarConfiguracion();
            await MostrarProductos();
        }
        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.Lista(buscar);
            var listaViewModel = listaProductos
                .Where(item => item.Activo == 1 && item.Stock > 0)
                .Select(item => new ProductoViewModel
                {
                    IdProducto = item.Id_Producto,
                    Codigo = item.Codigo,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    IdCategoria = item.RefCategoria.Id_Categoria,
                    Categoria = item.RefCategoria.Nombre,
                    PrecioCompra = decimal.Parse(item.PrecioCompra.ToString("0.00")),
                    PrecioVenta = decimal.Parse(item.PrecioVenta.ToString("0.00")),
                    Stock = item.Stock,
                    //Activo = item.Activo,
                    //Habilitado = item.Activo == 1 ? "SI" : "NO"
                }).ToList();
            ProductosDGV.DataSource = listaViewModel;

            ProductosDGV.Columns["Stock"].HeaderText = "Cantidad";
            ProductosDGV.Columns["PrecioCompra"].HeaderText = "P. Compra";
            ProductosDGV.Columns["PrecioVenta"].HeaderText = "P. Venta";

            ProductosDGV.Columns["IdProducto"].Visible = false;
            ProductosDGV.Columns["Activo"].Visible = false;
            ProductosDGV.Columns["Habilitado"].Visible = false;
            ProductosDGV.Columns["IdCategoria"].Visible = false;

            ProductosDGV.Columns["Descripcion"].Width = 200;
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarProductos(BuscarTextBox.Text.Trim());
        }

        private void ProductosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _productoSeleccionado = (ProductoViewModel)ProductosDGV.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
