

using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    public interface IMedidaRepository
    {
        Task<List<Medidas>> Lista();
    }
}
