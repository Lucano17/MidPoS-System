using PoS_Presentation.Utilities;
using PoS_Presentation.Utilities.Objetos;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Producto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        public frm_Producto(ICategoriaService categoriaService, IProductoService productoService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
        }

        public void MostrarTab(string tabName)
        {
            var TabsMenu = new TabPage[] { TabLista, TabNuevo, TabEditar };

            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.Lista(buscar);
            var listaViewModel = listaProductos.Select(item => new ProductoViewModel
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
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "SI" : "NO"
            }).ToList();
            ProductosDGV.DataSource = listaViewModel;

            ProductosDGV.Columns["Stock"].HeaderText = "Cantidad";
            ProductosDGV.Columns["PrecioCompra"].HeaderText = "P. Compra";
            ProductosDGV.Columns["PrecioVenta"].HeaderText = "P. Venta";

            ProductosDGV.Columns["IdProducto"].Visible = false;
            ProductosDGV.Columns["Activo"].Visible = false;
            ProductosDGV.Columns["IdCategoria"].Visible = false;

            ProductosDGV.Columns["Descripcion"].Width = 200;
        }

        private async void frm_Producto_Load(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
            ProductosDGV.ImplementarConfiguracion("Editar");

            PrecioCompraNuevoTextBox.ValidarNumero();
            PrecioVentaNuevoTextBox.ValidarNumero();

            PrecioCompraEditarTextBox.ValidarNumero();
            PrecioVentaEditarTextBox.ValidarNumero();

            await MostrarProductos();

            //ProductosDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OpcionCmbBox[] itemsHabilitado = new OpcionCmbBox[]
            {
                new OpcionCmbBox {Texto = "Si", Valor = 1},
                new OpcionCmbBox {Texto = "No", Valor = 0}
            };


            var listaCategoria = await _categoriaService.Lista();
            var items = listaCategoria
                .Where(item => item.Activo == 1)
                .Select(item => new OpcionCmbBox
                {
                    Texto = item.Nombre,
                    Valor = item.Id_Categoria
                })
                .ToArray();

            HabilitadoCmbBox.InsertarItems(itemsHabilitado);
            CategoriaNuevoCmbBox.InsertarItems(items);
            CategoriaEditarCmbBox.InsertarItems(items);
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarProductos(BuscarTextBox.Text);
        }

        private void NuevoListaButton_Click(object sender, EventArgs e)
        {
            CategoriaNuevoCmbBox.SelectedIndex = 0;
            NombreNuevoTextBox.Select();
            NombreNuevoTextBox.Text = "";
            CodigoNuevoTextBox.Text = "";
            DescripcionNuevoTextBox.Text = "";
            CantidadNuevoUpDown.Value = 0;
            PrecioVentaNuevoTextBox.Text = "";
            PrecioCompraNuevoTextBox.Text = "";

            MostrarTab(TabNuevo.Name);
        }

        private void VolverNuevoButton_Click(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
        }

        private void GuardarNuevoButton_Click(object sender, EventArgs e)
        {
            if (CodigoNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un código");
                return;
            }

            if (NombreNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el producto");
                return;
            }

            if (PrecioCompraNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio de compra para el producto");
                return;
            }

            if (PrecioVentaNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio de venta para el producto");
                return;
            }

            if (CantidadNuevoUpDown.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad de existencias del producto");
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;

            if (!decimal.TryParse(PrecioCompraNuevoTextBox.Text, out precioCompra))
            {
                MessageBox.Show("Precio de compra - Formato de moneda incorrecto", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PrecioCompraNuevoTextBox.Select();
                return;
            }

            if (!decimal.TryParse(PrecioVentaNuevoTextBox.Text, out precioVenta))
            {
                MessageBox.Show("Precio de venta - Formato de moneda incorrecto", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PrecioVentaNuevoTextBox.Select();
                return;
            }

        }
    }
}
