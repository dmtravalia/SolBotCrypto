using BotCrypto.ColetaInformacao.Application.Services;
using BotCrypto.ColetaInformacao.Data;
using BotCrypto.ColetaInformacao.Data.Repository;
using BotCrypto.ColetaInformacao.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkerService_ColetaInformacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();

                    // Catalogo
                    services.AddScoped<ITickerRepository, TickerRepository>();
                    services.AddScoped<ITickerService, TickerService>();
                    services.AddScoped<ITickerAppService, TickerAppService>();
                    services.AddScoped<ColetaInformacaoContext>();

                });
    }
}
