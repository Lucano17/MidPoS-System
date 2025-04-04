using Microsoft.Extensions.DependencyInjection;
using PoS_Service.Implementation;
using PoS_Service.Interfaces;

namespace PoS_Service
{
    public static class DependencyInjection
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
        }
    }
}
