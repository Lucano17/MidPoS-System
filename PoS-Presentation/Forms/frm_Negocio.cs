
using PoS_Repository.Entities;
using PoS_Service.Interfaces;
using PoS_Service.Resources.Cloudinary;
using System.Threading.Tasks;

namespace PoS_Presentation.Forms
{
    public partial class frm_Negocio : Form
    {
        private readonly INegocioService _negocioService;
        private readonly ICloudinaryService _cloudinaryService;
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        Negocio _negocio = new Negocio();
        public frm_Negocio(INegocioService negocioService, ICloudinaryService cloudinaryService)
        {
            InitializeComponent();
            _negocioService = negocioService;
            _cloudinaryService = cloudinaryService;
        }


        private async void frm_Negocio_Load(object sender, EventArgs e)
        {
            _openFileDialog.Filter = "Escoger imagen (*.JPG; *.JPEG; *.PNG;) | *.jpg; *.jpeg; *.png";
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

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _openFileDialog.OpenFile();
                LogoPictureBox.Image = Image.FromFile(_openFileDialog.FileName);

                rutaImagenTextBox.Text = _openFileDialog.FileName;
            }
        }

        private async void GuardarButton_Click(object sender, EventArgs e)
        {
            CloudinaryResponse cloudinaryResponse = new CloudinaryResponse();
            Negocio objeto = new Negocio();

            if (_openFileDialog.FileName != "")
            {
                cloudinaryResponse = await _cloudinaryService
                    .SubirImagen(_openFileDialog.SafeFileName, _openFileDialog.OpenFile());
                if (cloudinaryResponse.PublicID != "")
                {
                    if (_negocio.NombreLogo != "")
                        await _cloudinaryService.EliminarImagen(_negocio.NombreLogo);

                    objeto.NombreLogo = cloudinaryResponse.PublicID;
                    objeto.UrlLogo = cloudinaryResponse.SecureURL;

                    _negocio.NombreLogo = cloudinaryResponse.PublicID;
                    _negocio.UrlLogo = cloudinaryResponse.SecureURL;

                }
            }
            else
            {
                objeto.NombreLogo = _negocio.NombreLogo;
                objeto.UrlLogo = _negocio.UrlLogo;
            }

            objeto.RazonSocial = RazonSocialTextBox.Text.Trim();
            objeto.RUC = rucTextBox.Text.Trim();
            objeto.Correo = emailTextBox.Text.Trim();
            objeto.Direccion = direccionTextBox.Text.Trim();
            objeto.Celular = CelularTextBox.Text.Trim();
            objeto.Divisa = DivisaTextBox.Text.Trim();

            await _negocioService.Editar(objeto);

            MessageBox.Show("Los datos de tu negocio han sido editados correctamente");

            rutaImagenTextBox.Text = "";
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Escoger imagen (*.JPG; *.JPEG; *.PNG;) | *.jpg; *.jpeg; *.png";
        }
    }
}
