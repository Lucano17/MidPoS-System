using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categorias>> Lista(string buscar = "");
        Task<string> Crear(Categorias objeto);
        Task<string> Editar(Categorias objeto);
    }
}
