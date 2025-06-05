using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using PoS_Presentation.Utilities;
using PoS_Service.Interfaces;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Login : Form
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ICorreoService _correoService;
        private readonly IServiceProvider _serviceProvider;
        public frm_Login(IUsuarioService usuarioService, ICorreoService correoService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _correoService = correoService;
            _serviceProvider = serviceProvider;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Select();
        }

        private async void IngresarButton_Click(object sender, EventArgs e)
        {
            var encontrado = await _usuarioService.Login(UsuarioTextBox.Text, Util.ConvertToSha256(ClaveTextBox.Text));

            if (encontrado.Id_Usuario == 0)
            {
                MessageBox.Show("No se encontró el usuario");
                return;
            }
            if (encontrado.Activo == 0)
            {
                MessageBox.Show("El usuario se encuentra deshabilitado");
                return;
            }
            if (encontrado.ResetearClave == 1)
            {
                var formActualizarClave = _serviceProvider.GetRequiredService<frm_ActualizarClave>();
                formActualizarClave._idUsuario = encontrado.Id_Usuario;
                var resultado = formActualizarClave.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    ClaveTextBox.Text = "";
                    ClaveTextBox.Select();
                    MessageBox.Show("La contraseña fue actualizada, vuelva a ingresar");
                }
            }
            else
            {
                UsuarioSesion.Id_Usuario = encontrado.Id_Usuario;
                UsuarioSesion.NombreUsuario = encontrado.NombreUsuario;
                UsuarioSesion.Nombre = encontrado.Nombre;
                UsuarioSesion.Apellido = encontrado.Apellido;
                UsuarioSesion.Id_Rol = encontrado.RefRol.Id_Rol;
                UsuarioSesion.Rol = encontrado.RefRol.Nombre;

                // TODO: Actualizar formulario layout
                var formLayout = _serviceProvider.GetRequiredService<frm_Categoria>();
                this.Hide();
                UsuarioTextBox.Text = "";
                ClaveTextBox.Text = "";

                formLayout.Show();
                formLayout.FormClosed += (sender, e) =>
                {
                    this.Show();
                    UsuarioTextBox.Select();
                };
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void OlvideClaveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var correo = Interaction.InputBox
                ("Ingrese su correo de usuario", "Olvidé mi contraseña", "");
            var idUsuario = await _usuarioService.VerificarCorreo(correo);

            if (idUsuario == 0)
            {
                MessageBox.Show("No se encontró el usuario");
                return;
            }
            var claveGenerada = Util.GenerateCode();
            var claveSha256 = Util.ConvertToSha256(claveGenerada);

            await _usuarioService.ActualizarClave(idUsuario, claveSha256, 1);

            var mensaje = $"Contraseña actualizada <br> Su contraseña temporal es: {claveGenerada}";
            await _correoService.Enviar(correo, "Contraseña actualizada", mensaje);
            MessageBox.Show("Su contraseña fue actualizada, revise su correo");
        }
    }
}
