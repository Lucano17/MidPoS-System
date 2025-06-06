using Microsoft.Extensions.DependencyInjection;
using PoS_Repository.DB;
using PoS_Service.Implementation;
using PoS_Service.Interfaces;

namespace PoS_Service
{
    public static class DependencyInjection
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddSingleton<Connection>();
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<INegocioService, NegocioService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ICorreoService, CorreoService>();
            services.AddTransient<IVentaService, VentaService>();
            services.AddTransient<IMenuRolService, MenuRolService>();
        }
    }
}
