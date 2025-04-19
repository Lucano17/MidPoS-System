
using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    public interface IRolesRepository
    {
        Task<List<Roles>> Lista();
    }
}
