
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            return await _usuarioRepository.Lista(buscar);
        }
        public async Task<string> Crear(Usuario objeto)
        {
            return await _usuarioRepository.Crear(objeto);
        }

        public async Task<string> Editar(Usuario objeto)
        {
            return await _usuarioRepository.Editar(objeto);
        }

    }
}
