
using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario objeto);
        Task<string> Editar(Usuario objeto);
    }
}
