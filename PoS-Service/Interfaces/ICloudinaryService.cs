
using PoS_Service.Resources.Cloudinary;

namespace PoS_Service.Interfaces
{
    public interface ICloudinaryService
    {
        Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen);
        Task<bool> EliminarImagen(string publicID);
    }
}
