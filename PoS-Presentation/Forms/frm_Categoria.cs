using PoS_Presentation.ViewModels;
using PoS_Repository.Entities;
using PoS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var btnEditarColumn = new DataGridViewButtonColumn();
            btnEditarColumn.Text = "Editar";
            btnEditarColumn.Name = "ColumnaAccion";
            btnEditarColumn.HeaderText = "";
            btnEditarColumn.UseColumnTextForButtonValue = true;
            btnEditarColumn.Width = 50;
            btnEditarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            CategoriasDGV.Columns.Add(btnEditarColumn);


            await MostrarCategorias();

            CategoriasDGV.AllowUserToAddRows = false;
            CategoriasDGV.AllowUserToDeleteRows = false;
            CategoriasDGV.AllowUserToResizeColumns = true;
            CategoriasDGV.AllowUserToResizeRows = false;
            CategoriasDGV.AllowUserToOrderColumns = false;
            CategoriasDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CategoriasDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoriasDGV.MultiSelect = false;
            CategoriasDGV.RowHeadersVisible = false;
            CategoriasDGV.ReadOnly = true;
            CategoriasDGV.BackgroundColor = Color.White;
            CategoriasDGV.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(58, 49, 69),
                SelectionBackColor = Color.FromArgb(58, 49, 69),
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            CategoriasDGV.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 176, 209),
                SelectionForeColor = Color.FromArgb(0, 0, 0),
            };
            CategoriasDGV.ColumnHeadersHeight = 30;
            CategoriasDGV.EnableHeadersVisualStyles = false;
            CategoriasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CategoriasDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void CategoriasDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
