using PoS_Presentation.Utilities;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;
using System.Diagnostics;

namespace PoS_Presentation.Forms
{
    public partial class frm_DetalleVenta : Form
    {
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        public string _numeroVenta { get; set; } = null!;
        public frm_DetalleVenta(IVentaService ventaService, INegocioService negocioService)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _negocioService = negocioService;
        }

        private async void frm_DetalleVenta_Load(object sender, EventArgs e)
        {
            DetalleDataGridView.ImplementarConfiguracion();
            DetalleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var detalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);

            var listaVM = detalleVenta.Select(item => new DetalleVentaViewModel
            {
                Producto = item.RefProducto.Nombre,
                Precio = item.PrecioVenta,
                CantidadTexto = string.Concat
                    (item.Cantidad, " ", item.RefProducto.RefCategoria.RefMedida.Equivalente),
                Total = item.PrecioTotal
            }).ToList();

            NumeroVentaLabel.Text = _numeroVenta;

            DetalleDataGridView.DataSource = listaVM;
            DetalleDataGridView.Columns["IdProducto"].Visible = false;
            DetalleDataGridView.Columns["CantidadValor"].Visible = false;

        }

        private async void VerPDFButton_Click(object sender, EventArgs e)
        {
            var oNegocio = await _negocioService.Obtener();
            var oVenta = await _ventaService.Obtener(_numeroVenta);
            var oDetalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);
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
                saveFileDialog.FileName = $"{_numeroVenta}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await File.WriteAllBytesAsync(saveFileDialog.FileName, arrayPDF);
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = saveFileDialog.FileName,
                        UseShellExecute = true
                    });
                }

                // TODO: Poner precio total de todos los productos del DetalleVenta 
            }
        }
    }
}
