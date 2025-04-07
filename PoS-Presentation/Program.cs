using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PoS_Presentation.Forms;
using PoS_Repository;
using PoS_Repository.Implementation;
using PoS_Repository.Interfaces;
using PoS_Service;
using PoS_Service.Implementation;
using PoS_Service.Interfaces;

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

            var formService = host.Services.GetRequiredService<frm_Categoria>(); //Form1

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
                services.AddTransient<frm_Categoria>(); //Form1

            });
    }
}