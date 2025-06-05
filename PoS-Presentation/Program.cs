using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PoS_Presentation.Forms;
using PoS_Repository;
using PoS_Service;

namespace PoS_Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();

            var formService = host.Services.GetRequiredService<frm_Login>(); //Form1

            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.RegisterRepositoryDependencies();
                services.RegisterServiceDependencies();
                services.AddTransient<Form1>();
                services.AddTransient<frm_Categoria>();
                services.AddTransient<frm_Producto>();
                services.AddTransient<frm_Negocio>();
                services.AddTransient<frm_Usuario>();
                services.AddTransient<frm_Venta>();
                services.AddTransient<frm_BuscarProducto>();
                services.AddTransient<frm_Historial>();
                services.AddTransient<frm_DetalleVenta>();
                services.AddTransient<frm_ReporteVenta>();
                services.AddTransient<frm_Login>();
                services.AddTransient<frm_ActualizarClave>();

            });
    }
}