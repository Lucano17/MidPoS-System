
using PoS_Repository.Entities;

namespace PoS_Repository.Interfaces
{
    public interface IMenuRolRepository
    {
        Task<List<MenuRol>> Lista(int idRol);
    }
}
