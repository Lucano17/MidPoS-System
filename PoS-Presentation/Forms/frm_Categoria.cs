using PoS_Presentation.Utilities;
using PoS_Presentation.Utilities.Objetos;
using PoS_Presentation.ViewModels;
using PoS_Repository.Entities;
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
                Valor = item.Id_Medida
            }).ToArray();
            HabilitadoCmbBox.InsertarItems(itemsHabilitado);
            MedidaNuevoCmbBox.InsertarItems(items);
            MedidaEditarCmbBox.InsertarItems(items);
        }

        private void CategoriasDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoriasDGV.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSeleccionada = (CategoriaViewModel)CategoriasDGV.CurrentRow.DataBoundItem;
                NombreEditarTextBox.Text = categoriaSeleccionada.NombreCategoria.ToString();

                MedidaEditarCmbBox.EstablecerValor(categoriaSeleccionada.IdMedida);
                HabilitadoCmbBox.EstablecerValor(categoriaSeleccionada.Activo);

                MostrarTab(TabEditar.Name);
                NombreEditarTextBox.Select();

            }
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarCategorias(BuscarTextBox.Text);
        }

        private void NuevoListaButton_Click(object sender, EventArgs e)
        {
            NombreNuevoTextBox.Text = "";
            MedidaNuevoCmbBox.SelectedIndex = 0;
            NombreNuevoTextBox.Select();
            //tabControlMain.SelectedTab = tabControlMain.TabPages[TabNuevo.Name];

            MostrarTab(TabNuevo.Name);


        }

        private void VolverNuevoButton_Click(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
        }

        private async void GuardarNuevoButton_Click(object sender, EventArgs e)
        {
            if (NombreNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }

            if (MedidaNuevoCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una medida");
                return;
            }

            var medida = ((OpcionCmbBox)MedidaNuevoCmbBox.SelectedItem!).Valor;
            var objeto = new Categorias
            {
                Nombre = NombreNuevoTextBox.Text.Trim(),
                RefMedida = new Medidas { Id_Medida = medida }
            };

            var respuesta = await _categoriaService.Crear(objeto);

            if (!string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Elemento creado correctamente");
                await MostrarCategorias();
                MostrarTab(TabLista.Name);
            }
        }
        private void VolverEditarButton_Click(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
        }


        private void NombreNuevoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HabilitadoCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void GuardarEditarButton_Click(object sender, EventArgs e)
        {
            if (NombreEditarTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }

            if (MedidaEditarCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una medida");
                return;
            }
            var categoriaSeleccionada = (CategoriaViewModel)CategoriasDGV.CurrentRow.DataBoundItem;
            if (categoriaSeleccionada.IdCategoria == 0)
            {
                MessageBox.Show("Error: no se está obteniendo el Id de la categoría.");
                return;
            }
            var medida = ((OpcionCmbBox)MedidaEditarCmbBox.SelectedItem!).Valor;
            var habilitado = ((OpcionCmbBox)HabilitadoCmbBox.SelectedItem!).Valor;
            var objeto = new Categorias
            {
                Id_Categoria = categoriaSeleccionada.IdCategoria,
                Nombre = NombreEditarTextBox.Text.Trim(),
                RefMedida = new Medidas { Id_Medida = medida },
                Activo = habilitado
            };

            var respuesta = await _categoriaService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Elemento editado correctamente");
                await MostrarCategorias();
                MostrarTab(TabLista.Name);
            }
        }
    }
}
