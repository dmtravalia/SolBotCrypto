using BotCrypto.ColetaInformacao.Application.Services;
using BotCrypto.ColetaInformacao.Domain.Enum;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerService_ColetaInformacao
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ITickerAppService _tickerAppService;

        public Worker(ILogger<Worker> logger, ITickerAppService tickerAppService)
        {
            _logger = logger;
            _tickerAppService = tickerAppService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                await _tickerAppService.getTicker(TipoMoeda.BCH);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
