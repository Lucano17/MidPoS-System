
using ClosedXML.Excel;
using PoS_Presentation.Utilities;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;
using System.Data;

namespace PoS_Presentation.Forms
{
    public partial class frm_ReporteVenta : Form
    {
        private readonly IVentaService _ventaService;
        public frm_ReporteVenta(IVentaService ventaService)
        {
            InitializeComponent();
            _ventaService = ventaService;
        }

        private void frm_ReporteVenta_Load(object sender, EventArgs e)
        {
            ReporteDataGridView.ImplementarConfiguracion();
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = await _ventaService.ReporteVenta(
                FechaInicioDTP.Value.ToString("dd/MM/yyyy"),
                FechaFinDTP.Value.ToString("dd/MM/yyyy")
                );
            var listaVM = lista.Select(item => new ReporteVentaViewModel
            {
                NumeroVenta = item.RefVenta.NumeroVenta,
                NombreUsuario = item.RefVenta.UsuarioRegistro.NombreUsuario,
                FechaRegistro = item.RefVenta.FechaRegistro,
                Producto = item.RefProducto.Nombre,
                PrecioCompra = item.RefProducto.PrecioCompra,
                PrecioVenta = item.PrecioVenta,
                Cantidad = item.Cantidad,
                PrecioTotal = item.RefVenta.PrecioTotal
            }).ToList();
            ReporteDataGridView.DataSource = listaVM;
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            if (ReporteDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados");
                return;
            }
            DataTable tabla = new DataTable();
            List<ReporteVentaViewModel> detalle =
                (List<ReporteVentaViewModel>)ReporteDataGridView.DataSource;

            foreach (DataGridViewColumn columna in ReporteDataGridView.Columns)
            {
                tabla.Columns.Add(columna.HeaderText, typeof(string));
            }

            foreach (var item in detalle)
            {
                tabla.Rows.Add(
                    item.NumeroVenta,
                    item.NombreUsuario,
                    item.FechaRegistro,
                    item.Producto,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Cantidad,
                    item.PrecioTotal
                    );
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.FileName = $"ReporteVenta_{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xlsx";
                saveFile.Filter = "Excel files|*.xslx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(tabla, "Reporte");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show
                            ("Reporte generado", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show
                           ("Error al generar", "Mensaje", MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                    }
                }
            }

        }
    }
}
