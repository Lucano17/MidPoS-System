
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PoS_Repository.Entities
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public Roles RefRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int ResetearClave { get; set; }
        public int Activo { get; set; }
    }
}
