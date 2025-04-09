
using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Productos>> Lista(string buscar = "");
        Task<string> Crear(Productos objeto);
        Task<string> Editar(Productos objeto);
    }
}
