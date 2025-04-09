using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IProductoService
    {
        Task<List<Productos>> Lista(string buscar = "");
        Task<string> Crear(Productos objeto);
        Task<string> Editar(Productos objeto);
    }
}
