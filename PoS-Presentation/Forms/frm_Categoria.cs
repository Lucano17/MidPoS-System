using PoS_Presentation.Utilities;
using PoS_Presentation.Utilities.Objetos;
using PoS_Presentation.ViewModels;
using PoS_Service.Interfaces;
using System.Data;

namespace PoS_Presentation.Forms
{
    public partial class frm_Categoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;
        public frm_Categoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
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

        private void VolverEditarButton_Click(object sender, EventArgs e)
        {

        }
        private async Task MostrarCategorias(string buscar = "")
        {
            var listaCategorias = await _categoriaService.Lista(buscar);
            var listaViewModel = listaCategorias.Select(item => new CategoriaViewModel
            {
                IdCategoria = item.Id_Categoria,
                NombreCategoria = item.Nombre,
                IdMedida = item.RefMedida.Id_Medida,
                Medida = item.RefMedida.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "SI" : "NO"
            }).ToList();
            CategoriasDGV.DataSource = listaViewModel;

            CategoriasDGV.Columns["NombreCategoria"].HeaderText = "Categoría";

            CategoriasDGV.Columns["IdCategoria"].Visible = false;
            CategoriasDGV.Columns["Activo"].Visible = false;
            CategoriasDGV.Columns["IdMedida"].Visible = false;
        }
        private async void frm_Categoria_Load(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
            CategoriasDGV.ImplementarConfiguracion("Editar");
            await MostrarCategorias();

            CategoriasDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OpcionCmbBox[] itemsHabilitado = new OpcionCmbBox[]
            {
                new OpcionCmbBox {Texto = "Si", Valor = 1},
                new OpcionCmbBox {Texto = "No", Valor = 0}
            };


            var listaMedida = await _medidaService.Lista();
            var items = listaMedida.Select(item => new OpcionCmbBox
            {
                Texto = item.Nombre,
                Valor = item.Valor
            }).ToArray();
            HabilitadoCmbBox.InsertarItems(itemsHabilitado);
            MedidaNuevoCmbBox.InsertarItems(items);
            MedidaEditarCmbBox.InsertarItems(items);
        }

        private void CategoriasDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarCategorias(BuscarTextBox.Text);
        }

        private void NuevoListaButton_Click(object sender, EventArgs e)
        {
            NombreNuevoLabel.Text = "";
            MedidaNuevoCmbBox.SelectedIndex = 0;
            NombreNuevoLabel.Select();
            //tabControlMain.SelectedTab = tabControlMain.TabPages[TabNuevo.Name];

            MostrarTab(TabNuevo.Name);


        }
    }
}
