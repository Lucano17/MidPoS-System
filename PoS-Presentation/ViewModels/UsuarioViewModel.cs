
namespace PoS_Presentation.ViewModels
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Habilitado { get; set; }
        public int Activo { get; set; }

        public string NombreCompleto => $"{Apellido.ToUpper()}, {Nombre}";
    }
}
