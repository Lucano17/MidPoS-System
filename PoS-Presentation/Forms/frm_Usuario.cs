using CloudinaryDotNet.Actions;
using PoS_Presentation.Utilities;
using PoS_Presentation.Utilities.Objetos;
using PoS_Presentation.ViewModels;
using PoS_Repository.Entities;
using PoS_Service.Implementation;
using PoS_Service.Interfaces;
using System.Data;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Usuario : Form
    {
        private readonly IRolesService _rolService;
        private readonly IUsuarioService _usuarioService;
        private readonly ICorreoService _correoService;
        public frm_Usuario(IRolesService rolService, IUsuarioService usuarioService, ICorreoService correoService)
        {
            InitializeComponent();
            _rolService = rolService;
            _usuarioService = usuarioService;
            _correoService = correoService;
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

        private async Task MostrarUsuarios(string buscar = "")
        {
            var listaUsuarios = await _usuarioService.Lista(buscar);
            var listaViewModel = listaUsuarios.Select(item => new UsuarioViewModel
            {
                IdUsuario = item.Id_Usuario,
                Nombre = item.Nombre,
                Apellido = item.Apellido,
                NombreUsuario = item.NombreUsuario,
                Correo = item.Correo,
                IdRol = item.RefRol.Id_Rol,
                Rol = item.RefRol.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "SI" : "NO"
            }).ToList();
            UsuariosDGV.DataSource = listaViewModel;

            UsuariosDGV.Columns["NombreCompleto"].DisplayIndex = 1;
            UsuariosDGV.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            UsuariosDGV.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";

            UsuariosDGV.Columns["Nombre"].Visible = false;
            UsuariosDGV.Columns["Apellido"].Visible = false;
            UsuariosDGV.Columns["IdUsuario"].Visible = false;
            UsuariosDGV.Columns["IdRol"].Visible = false;
            UsuariosDGV.Columns["Activo"].Visible = false;
        }

        private async void frm_Usuario_Load(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
            UsuariosDGV.ImplementarConfiguracion("Editar");
            await MostrarUsuarios();

            UsuariosDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OpcionCmbBox[] itemsHabilitado = new OpcionCmbBox[]
            {
                new OpcionCmbBox {Texto = "Si", Valor = 1},
                new OpcionCmbBox {Texto = "No", Valor = 0}
            };

            var listaRol = await _rolService.Lista();
            var items = listaRol.Select(item => new OpcionCmbBox
            {
                Texto = item.Nombre,
                Valor = item.Id_Rol
            }).ToArray();
            HabilitadoCmbBox.InsertarItems(itemsHabilitado);
            RolNuevoCmbBox.InsertarItems(items);
            RolEditarCmbBox.InsertarItems(items);
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios(BuscarTextBox.Text);
        }

        private void NuevoListaButton_Click(object sender, EventArgs e)
        {
            NombreNuevoTextBox.Text = "";
            ApellidoNuevoTextBox.Text = "";
            NombreUsuarioNuevoTextBox.Text = "";
            CorreoNuevoTextBox.Text = "";
            RolNuevoCmbBox.SelectedIndex = 0;
            NombreNuevoTextBox.Select();
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

            if (ApellidoNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return;
            }

            if (NombreUsuarioNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }

            if (CorreoNuevoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un correo");
                return;
            }

            if (RolNuevoCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }

            var claveGenerada = Util.GenerateCode();
            var claveSHA256 = Util.ConvertToSha256(claveGenerada);
            var rol = ((OpcionCmbBox)RolNuevoCmbBox.SelectedItem!).Valor;
            var objeto = new Usuario
            {
                Nombre = NombreNuevoTextBox.Text.Trim(),
                Apellido = ApellidoNuevoTextBox.Text.Trim(),
                NombreUsuario = NombreUsuarioNuevoTextBox.Text.Trim(),
                Correo = CorreoNuevoTextBox.Text.Trim(),
                Clave = claveSHA256,
                RefRol = new Roles { Id_Rol = rol }
            };

            var respuesta = await _usuarioService.Crear(objeto);

            if (!string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                var mensaje = $"Bienvenido</br>Su contraseña temporal es: {claveGenerada}";
                await _correoService.Enviar(objeto.Correo, "Cuenta creada", mensaje);

                MessageBox.Show("Usuario creado exitosamente");
                await MostrarUsuarios();
                MostrarTab(TabLista.Name);
            }
        }

        private void UsuariosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsuariosDGV.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var usuarioSeleccionado = (UsuarioViewModel)UsuariosDGV.CurrentRow.DataBoundItem;
                NombreEditarTextBox.Text = usuarioSeleccionado.Nombre.ToString();
                ApellidoEditarTextBox.Text = usuarioSeleccionado.Apellido.ToString();
                NombreUsuarioEditarTextBox.Text = usuarioSeleccionado.NombreUsuario.ToString();
                CorreoEditarTextBox.Text = usuarioSeleccionado.Correo.ToString();

                RolEditarCmbBox.EstablecerValor(usuarioSeleccionado.IdRol);
                HabilitadoCmbBox.EstablecerValor(usuarioSeleccionado.Activo);

                MostrarTab(TabEditar.Name);
                NombreEditarTextBox.Select();

            }
        }

        private void VolverEditarButton_Click(object sender, EventArgs e)
        {
            MostrarTab(TabLista.Name);
        }

        private async void GuardarEditarButton_Click(object sender, EventArgs e)
        {
            if (NombreEditarTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }

            if (ApellidoEditarTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return;
            }

            if (NombreUsuarioEditarTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }

            if (CorreoEditarTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un correo");
                return;
            }

            if (RolNuevoCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }

            if (HabilitadoCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una opción");
                return;
            }

            var usuarioSeleccionado = (UsuarioViewModel)UsuariosDGV.CurrentRow.DataBoundItem;
            if (usuarioSeleccionado.IdUsuario == 0)
            {
                MessageBox.Show("Error: no se está obteniendo el Id de la categoría.");
                return;
            }
            var rol = ((OpcionCmbBox)RolEditarCmbBox.SelectedItem!).Valor;
            var habilitado = ((OpcionCmbBox)HabilitadoCmbBox.SelectedItem!).Valor;
            var objeto = new Usuario
            {
                Id_Usuario = usuarioSeleccionado.IdUsuario,
                Nombre = NombreEditarTextBox.Text.Trim(),
                Apellido = ApellidoEditarTextBox.Text.Trim(),
                NombreUsuario = NombreUsuarioEditarTextBox.Text.Trim(),
                Correo = CorreoEditarTextBox.Text.Trim(),
                RefRol = new Roles { Id_Rol = rol },
                Activo = habilitado
            };

            var respuesta = await _usuarioService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Usuario editado correctamente");
                await MostrarUsuarios();
                MostrarTab(TabLista.Name);
            }
        }
    }
}

