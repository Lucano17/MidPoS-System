using PoS_Repository.Entities;

namespace PoS_Service.Interfaces
{
    public interface IMenuRolService
    {
        Task<List<MenuRol>> Lista(int idRol);
    }
}
