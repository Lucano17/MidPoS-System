

using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IRolesService
    {
        Task<List<Roles>> Lista();
    }
}
