

using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IMedidaService
    {
        Task<List<Medidas>> Lista();
    }
}
