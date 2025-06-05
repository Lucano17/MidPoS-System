
using PoS_Presentation.Utilities;
using PoS_Service.Interfaces;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_ActualizarClave : Form
    {
        private readonly IUsuarioService _usuarioService;
        public int _idUsuario { get; set; }
        public frm_ActualizarClave(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void frm_ActualizarClave_Load(object sender, EventArgs e)
        {
            ValidacionLabel.Visible = false;
            ClaveTextBox.Select();
        }

        private async void GuardarButton_Click(object sender, EventArgs e)
        {
            if (ClaveTextBox.Text != RepetirClaveTextBox.Text)
            {
                ValidacionLabel.Visible = true;
                return;
            }
            await _usuarioService.ActualizarClave(_idUsuario, Util.ConvertToSha256(ClaveTextBox.Text), 0);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
