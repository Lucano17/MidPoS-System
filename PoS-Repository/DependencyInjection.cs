

using Microsoft.Extensions.DependencyInjection;
using PoS_Repository.Implementation;
using PoS_Repository.Interfaces;

namespace PoS_Repository
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoryDependencies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaRepository, MedidaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<INegocioRepository, NegocioRepository>();
        }
    }
}
