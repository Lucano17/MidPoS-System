

using Microsoft.Extensions.DependencyInjection;
using PoS_Presentation.Utilities;
using PoS_Presentation.ViewModels;
using PoS_Repository.Entities;
using PoS_Service.Interfaces;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Historial : Form
    {
        private readonly IVentaService _ventaService;
        private readonly IServiceProvider _serviceProvider;

        public frm_Historial(IServiceProvider serviceProvider, IVentaService ventaService)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _serviceProvider = serviceProvider;
        }
        private async Task MostrarVenta()
        {
            var listaVenta = await _ventaService.Lista(
                FechaInicioDTP.Value.ToString("dd/MM/yyyy"),
                FechaFinDTP.Value.ToString("dd/MM/yyyy"),
                EncontrarTextBox.Text.Trim()

                );
            var listaVM = listaVenta.Select(item => new VentaViewModel
            {
                FechaRegistro = item.FechaRegistro,
                NumeroVenta = item.NumeroVenta,
                Usuario = item.UsuarioRegistro.NombreUsuario,
                Cliente = item.NombreCliente,
                Total = item.PrecioTotal
            }).ToList();

            VentaDataGridView.DataSource = listaVM;
        }

        private void frm_Historial_Load(object sender, EventArgs e)
        {
            VentaDataGridView.ImplementarConfiguracion("Ver");
            VentaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarVenta();
        }

        private void VentaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VentaDataGridView.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (VentaViewModel)VentaDataGridView.CurrentRow.DataBoundItem;
                var formDetalle = _serviceProvider.GetRequiredService<frm_DetalleVenta>();
                formDetalle._numeroVenta = filaSeleccionada.NumeroVenta;
                formDetalle.ShowDialog();
            }
        }
    }
}
