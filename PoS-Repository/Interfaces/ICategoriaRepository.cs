
using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    interface ICategoriaRepository
    {
        Task<List<Categorias>> Lista(string buscar = "");
        Task<string> Crear(Categorias objeto);
        Task<string> Editar(Categorias objeto);
    }
}
