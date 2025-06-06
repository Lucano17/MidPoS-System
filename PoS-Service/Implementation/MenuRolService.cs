
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class MenuRolService : IMenuRolService
    {
        readonly private IMenuRolRepository _menuRolRepository;

        public MenuRolService(IMenuRolRepository menuRolRepository)
        {
            _menuRolRepository = menuRolRepository;
        }
        public async Task<List<MenuRol>> Lista(int idRol)
        {
            return await _menuRolRepository.Lista(idRol);
        }
    }
}
