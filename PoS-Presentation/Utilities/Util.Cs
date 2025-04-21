
using System.Security.Cryptography;
using System.Text;

namespace PoS_Presentation.Utilities
{
    public static class Util
    {
        public static string GenerateCode()
        {
            var guid = Guid.NewGuid().ToString("N").Substring(0, 6);
            return guid;
        }

        public static string ConvertToSha256(string texto)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                // Convertir la cadena de entrada en un array de bytes
                byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                // Construir el string del hash
                StringBuilder builder = new();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
            }
            return "";
        }
    }
}
