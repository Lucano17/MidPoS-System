

using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    public interface INegocioRepository
    {
        Task<Negocio> Obtener();
        Task Editar(Negocio objeto);
    }
}
