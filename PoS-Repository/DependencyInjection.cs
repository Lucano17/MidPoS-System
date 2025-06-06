using Microsoft.Extensions.DependencyInjection;
using PoS_Repository.Implementation;
using PoS_Repository.Interfaces;
using PoS_Service.Interfaces;

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
            services.AddTransient<IRolesRepository, RolesRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IVentaRepository, VentaRepository>();
            services.AddTransient<IMenuRolRepository, MenuRolRepository>();
        }
    }
}
