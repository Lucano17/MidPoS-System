
using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface INegocioService
    {
        Task<Negocio> Obtener();
        Task Editar(Negocio objeto);
    }
}
