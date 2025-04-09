

using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

namespace PoS_Service.Implementation
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<List<Productos>> Lista(string buscar = "")
        {
            return await _productoRepository.Lista(buscar);
        }

        public async Task<string> Crear(Productos objeto)
        {
            return await _productoRepository.Crear(objeto);
        }

        public async Task<string> Editar(Productos objeto)
        {
            return await _productoRepository.Editar(objeto);
        }


    }
}
