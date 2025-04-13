
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    class NegocioService : INegocioService
    {
        private readonly INegocioRepository _negocioRepository;
        public NegocioService(INegocioRepository negocioRepository)
        {
            _negocioRepository = negocioRepository;
        }
        public async Task<Negocio> Obtener()
        {
            return await _negocioRepository.Obtener();
        }

        public async Task Editar(Negocio objeto)
        {
            await _negocioRepository.Editar(objeto);
        }
    }
}
