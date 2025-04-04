using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_Service.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<string> Crear(Categorias objeto)
        {
            return await _categoriaRepository.Crear(objeto);
        }

        public async Task<string> Editar(Categorias objeto)
        {
            return await _categoriaRepository.Editar(objeto);
        }

        public async Task<List<Categorias>> Lista(string buscar = "")
        {
            return await _categoriaRepository.Lista(buscar);
        }
    }
}
