using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using PoS_Presentation.Utilities;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace PoS_Presentation.Forms
{
    public partial class frm_Venta : Form
    {
        private readonly IProductoService _productoService;
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        private readonly IServiceProvider _serviceProvider;
        private BindingList<DetalleVentaViewModel> _detalleVenta = new BindingList<DetalleVentaViewModel>();
        public frm_Venta(IProductoService productoService, IVentaService ventaService,
            INegocioService negocioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _productoService = productoService;
            _ventaService = ventaService;
            _negocioService = negocioService;
            _serviceProvider = serviceProvider;
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            DetalleVentaDGV.ImplementarConfiguracion("Eliminar");
            DetalleVentaDGV.DataSource = _detalleVenta;
            DetalleVentaDGV.Columns["IdProducto"].Visible = false;
            DetalleVentaDGV.Columns["CantidadValor"].Visible = false;
            DetalleVentaDGV.Columns["Producto"].FillWeight = 350;
            DetalleVentaDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            PagoConTextBox.ValidarNumero();
        }

        private async Task AgregarProducto(string codigoProducto)
        {
            var producto = await _productoService.Obtener(codigoProducto);
            if (producto.Id_Producto == 0)
            {
                CodigoProductoTextBox.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }

            CodigoProductoTextBox.BackColor = SystemColors.Window;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(producto.Nombre);
            sb.AppendLine($"Categoría: {producto.RefCategoria.Nombre}");
            sb.AppendLine($"Precio de venta: {producto.PrecioVenta.ToString("0.00")}");
            sb.AppendLine();
            sb.AppendLine($"Ingresa la cantidad ({producto.RefCategoria.RefMedida.Equivalente});");

            string cantidadString = Interaction.InputBox(sb.ToString(), "Producto", "1");

            if (string.IsNullOrEmpty(cantidadString)) return;

            int cantidad;

            if (!int.TryParse(cantidadString, out cantidad))
            {
                MessageBox.Show("El valor ingresado no es un número");
                return;
            }

            if (cantidad > producto.Stock)
            {
                MessageBox.Show("La cantidad ingresada no puede exceder al stock");
                return;
            }

            var encontrado = _detalleVenta.FirstOrDefault(x => x.IdProducto == producto.Id_Producto);

            if (encontrado == null)
            {
                decimal total = (cantidad * producto.PrecioVenta) / producto.RefCategoria.RefMedida.Valor;
                _detalleVenta.Add(new DetalleVentaViewModel
                {
                    IdProducto = producto.Id_Producto,
                    Producto = producto.Nombre,
                    Precio = producto.PrecioVenta,
                    CantidadValor = cantidad,
                    CantidadTexto = string.Concat(cantidad, " ", producto.RefCategoria.RefMedida.Equivalente),
                    Total = Convert.ToDecimal(total.ToString("0.00"))
                });
            }
            else
            {
                int index = _detalleVenta.IndexOf(encontrado);
                int cantidadTotal = encontrado.CantidadValor + cantidad;
                decimal total = (cantidadTotal * producto.PrecioVenta) / producto.RefCategoria.RefMedida.Valor;

                encontrado.CantidadValor = cantidadTotal;
                encontrado.CantidadTexto =
                    string.Concat(cantidadTotal + " " + producto.RefCategoria.RefMedida.Equivalente);
                encontrado.Total = Convert.ToDecimal(total.ToString("0.00"));
                _detalleVenta[index] = encontrado;
            }

            decimal Total = _detalleVenta.Sum(x => x.Total);
            TotalPriceLabel.Text = Total.ToString("0.00");
            CodigoProductoTextBox.Text = "";
        }

        private async void CodigoProductoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await AgregarProducto(CodigoProductoTextBox.Text.Trim());
            }
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            var _formBuscarProducto = _serviceProvider.GetRequiredService<frm_BuscarProducto>();
            var resultado = _formBuscarProducto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                var productoSeleccionado = _formBuscarProducto._productoSeleccionado;
                CodigoProductoTextBox.Text = productoSeleccionado.Codigo;
                await AgregarProducto(productoSeleccionado.Codigo);
            }
        }

        private void DetalleVentaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleVentaDGV.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (DetalleVentaViewModel)DetalleVentaDGV.CurrentRow.DataBoundItem;
                var index = _detalleVenta.IndexOf(filaSeleccionada);
                _detalleVenta.RemoveAt(index);
                decimal Total = _detalleVenta.Sum(x => x.Total);
                TotalPriceLabel.Text = Total.ToString("0.00");
            }
        }

        private async void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (_detalleVenta.Count == 0)
            {
                MessageBox.Show("No hay productos");
                return;
            }

            decimal tempTotal = _detalleVenta.Sum(x => x.Total);

            var precioTotal = Convert.ToDecimal(tempTotal.ToString("0.00"));

            var pagoCon = PagoConTextBox.Text.Trim() == ""
                ? precioTotal
                : Convert.ToDecimal(PagoConTextBox.Text.Trim());

            var cambio = CambioTextBox.Text.Trim() == ""
                ? 0
                : Convert.ToDecimal(CambioTextBox.Text.Trim());

            // TODO: Ingresar el ID del usuario logueado
            XElement venta = new XElement("Venta",
                new XElement("Id_UsuarioRegistro", 1),
                new XElement("NombreCliente", NombreClienteTextBox.Text.Trim()),
                new XElement("PrecioTotal", precioTotal),
                new XElement("PagoCon", pagoCon),
                new XElement("Cambio", cambio)
                );

            XElement detalleVenta = new XElement("DetalleVenta");
            foreach (DetalleVentaViewModel item in _detalleVenta)
            {
                detalleVenta.Add(new XElement("Item",
                    new XElement("Id_Producto", item.IdProducto),
                    new XElement("Cantidad", item.CantidadValor),
                    new XElement("PrecioVenta", item.Precio),
                    new XElement("PrecioTotal", item.Total)
                    ));
            }
            venta.Add(detalleVenta);

            var numeroVenta = await _ventaService.Registrar(venta.ToString());

            if (numeroVenta == "")
            {
                MessageBox.Show("No se pudo generar la venta");
                return;
            }

            CodigoProductoTextBox.Text = "";
            NombreClienteTextBox.Text = "";
            _detalleVenta.Clear();
            PagoConTextBox.Text = "";
            CambioTextBox.Text = "";
            TotalPriceLabel.Text = "0";
            CodigoProductoTextBox.Select();

            DialogResult result = MessageBox.Show(
                $"Número de venta: {numeroVenta}, ¿Desea guardar y visualizar el documento?",
                "Registrado correctamente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );

            if (result == DialogResult.Yes)
            {
                var oNegocio = await _negocioService.Obtener();
                var oVenta = await _ventaService.Obtener(numeroVenta);
                var oDetalleVenta = await _ventaService.ObtenerDetalle(numeroVenta);
                oVenta.RefDetalleVenta = oDetalleVenta;

                MemoryStream imagenLogo;
                using (var httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(oNegocio.UrlLogo);
                    imagenLogo = new MemoryStream(imageBytes);
                }

                var arrayPDF = Util.GeneratePDFVenta(oNegocio, oVenta, imagenLogo);
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar PDF";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = $"{numeroVenta}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await File.WriteAllBytesAsync(saveFileDialog.FileName, arrayPDF);
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
        }

        private void PagoConTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            decimal pagoCon;
            decimal total = _detalleVenta.Sum(x => x.Total);

            if (PagoConTextBox.Text.Trim() != "")
            {
                if (decimal.TryParse(PagoConTextBox.Text.Trim(), out pagoCon))
                {
                    if (pagoCon < total)
                    {
                        CambioTextBox.Text = "0.00";
                    }
                    else
                    {
                        decimal cambio = pagoCon - total;
                        CambioTextBox.Text = cambio.ToString("0.00");
                    }
                }
                else
                {
                    MessageBox.Show("El monto seleccionado no es válido");
                }
            }
        }
    }
}
