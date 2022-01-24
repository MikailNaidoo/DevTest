using Microsoft.Extensions.Configuration;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RenderTheGoods.Logic;
using RenderTheGoods.Models;

namespace RenderTheGoods
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

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context,builder)=>
                {
                    builder.AddJsonFile("appsettings.json",optional:true);
                })
                .ConfigureServices((context, services) =>
                {
                    ConfigurationServices(context.Configuration,services);
                })
                .Build();



            var services=host.Services;
            var inputForm=services.GetService<InputForm>();
            Application.Run(inputForm);
        }

        private static void ConfigurationServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<InputForm>();
            services.AddScoped<IRectangleRepository,RectangleRepository>();
            
            
        }
    }
}