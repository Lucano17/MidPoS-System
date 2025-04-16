
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using PoS_Service.Interfaces;
using PoS_Service.Resources.Cloudinary;
using System.Net;

namespace PoS_Service.Implementation
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IConfiguration _configuration;
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration configuration)
        {
            _configuration = configuration;
            var cloudName = _configuration["Cloudinary:CloudName"];
            var apiKey = _configuration["Cloudinary:ApiKey"];
            var apiSecret = _configuration["Cloudinary:ApiSecret"];

            _cloudinary = new Cloudinary(new Account(cloudName, apiKey, apiSecret));

        }
        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            var cloudinaryResponse = new CloudinaryResponse();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nombreImagen, formatoImagen),
                AssetFolder = "MidPoS-System"
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode == HttpStatusCode.OK)
            {
                cloudinaryResponse.PublicID = uploadResult.PublicId;
                cloudinaryResponse.SecureURL = uploadResult.SecureUrl.ToString();
            }
            else
            {
                cloudinaryResponse.PublicID = "";
            }

            return cloudinaryResponse;
        }
        public async Task<bool> EliminarImagen(string publicID)
        {
            var deleteParams = new DeletionParams(publicID);

            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            if (deleteResult.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
