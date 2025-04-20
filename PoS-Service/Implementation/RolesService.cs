
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _rolesRepository;
        public RolesService(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public Task<List<Roles>> Lista()
        {
            return _rolesRepository.Lista();
        }
    }
}
