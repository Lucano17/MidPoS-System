
using PoS_Repository.Entities;
using PoS_Service.Interfaces;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Negocio : Form
    {
        private readonly INegocioService _negocioService;
        private readonly ICloudinaryService _cloudinaryService;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Negocio _negocio = new Negocio();
        public frm_Negocio(INegocioService negocioService, ICloudinaryService cloudinaryService)
        {
            InitializeComponent();
            _negocioService = negocioService;
            _cloudinaryService = cloudinaryService;
        }


        private async void frm_Negocio_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Escoger imagen (*.JPG; *.JPEG; *.PNG;) | *.jpg; *.jpeg; *.png";
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            _negocio = await _negocioService.Obtener();

            RazonSocialTextBox.Text = _negocio.RazonSocial;
            rucTextBox.Text = _negocio.RUC;
            emailTextBox.Text = _negocio.Correo;
            direccionTextBox.Text = _negocio.Direccion;
            CelularTextBox.Text = _negocio.Celular;
            DivisaTextBox.Text = _negocio.Divisa;

            if (_negocio.UrlLogo != "") LogoPictureBox.ImageLocation = _negocio.UrlLogo;
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
