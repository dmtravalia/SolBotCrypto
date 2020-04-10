using BotCrypto.ColetaInformacao.Application.Services;
using BotCrypto.ColetaInformacao.Data;
using BotCrypto.ColetaInformacao.Data.Repository;
using BotCrypto.ColetaInformacao.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
                    IConfiguration configuration = hostContext.Configuration;

                    services.AddHostedService<Worker>();

                    services.AddDbContext<ColetaInformacaoContext>(options => options.UseMySql(configuration.GetConnectionString("DefaultConnection")));

                    //ColetaInformacao                    
                    services.AddTransient<ITickerService, TickerService>();
                    services.AddTransient<ITickerAppService, TickerAppService>();
                    services.AddTransient<ITickerRepository, TickerRepository>();
                    services.AddTransient<ColetaInformacaoContext>();

                });
    }
}
