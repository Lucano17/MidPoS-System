
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class MedidaService : IMedidaService
    {
        private readonly IMedidaRepository _medidaRepository;
        public MedidaService(IMedidaRepository medidaRepository)
        {
            _medidaRepository = _medidaRepository;
        }

        public async Task<List<Medidas>> Lista()
        {
            return await _medidaRepository.Lista();
        }
    }
}
