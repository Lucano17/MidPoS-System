using Microsoft.Extensions.DependencyInjection;
using PoS_Presentation.Utilities;
using PoS_Service.Interfaces;

namespace PoS_Presentation.Forms
{
    public partial class Layout : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMenuRolService _menuRolService;
        public Layout(IServiceProvider serviceProvider, IMenuRolService menuRolService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _menuRolService = menuRolService;
        }

        private async void Layout_Load(object sender, EventArgs e)
        {
            msMenu.Renderer = new CustomToolStripRender();
            UsuarioLabel.Text = $"Usuario: {UsuarioSesion.NombreUsuario}";
            RolLabel.Text = $"Rol: {UsuarioSesion.Rol}";

            var listaPrincipal = await _menuRolService.Lista(UsuarioSesion.Id_Rol);
            var menusPadres = listaPrincipal.Where(x => x.Id_MenuPadre == 0).ToList();
            var menusHijos = listaPrincipal.Where(x => x.Id_MenuPadre != 0).ToList();
            var menus = new ToolStripMenuItem[]
                { VentasMN, InventarioMN, ReportesMN, UsuariosMN, ConfiguracionMN };
            var submenus = new ToolStripMenuItem[]
                { NuevoSM, HistorialSM, ProductosSM, CategoriasSM,VentasSM };

            foreach (var menu in menus)
            {
                var encontrado = menusPadres
                    .Exists(x => x.NombreMenu == menu.Tag!.ToString() && x.Activo);

                if (encontrado)
                    menu.Visible = true;
                else
                    menu.Visible = false;
            }

            foreach (var submenu in submenus)
            {
                var encontrado = menusHijos
                    .Exists(x => x.NombreMenu == submenu.Tag!.ToString() && x.Activo);

                if (encontrado)
                    submenu.Visible = true;
                else
                    submenu.Visible = false;
            }

        }

        private void NuevoSM_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Venta>();
        }

        private void HistorialSM_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Historial>();
        }

        private void ProductosSM_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Producto>();
        }

        private void CategoriasSM_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Categoria>();
        }

        private void VentasSM_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_ReporteVenta>();
        }

        private void UsuariosMN_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Usuario>();
        }

        private void ConfiguracionMN_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frm_Negocio>();
        }

        private void SesionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void MostrarFormulario<TForm>() where TForm : Form
        {
            if (PanelMain.Controls.Count > 0) PanelMain.Controls[0].Dispose();

            var newForm = _serviceProvider.GetRequiredService<TForm>();
            newForm.TopLevel = false;
            newForm.TopMost = false;
            PanelMain.Controls.Add(newForm);
            newForm.Show();
        }
    }
}

