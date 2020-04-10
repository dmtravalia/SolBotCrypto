using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.ColetaInformacao.Domain.Enum;
using System.Threading.Tasks;

namespace BotCrypto.ColetaInformacao.Application.Services
{
    public class TickerAppService : ITickerAppService
    {
        private readonly ITickerRepository _tickerRepository;
        private readonly ITickerService _tickerService;

        public TickerAppService(ITickerService tickerService)//, ITickerRepository tickerRepository)
        {
            //_tickerRepository = tickerRepository;
            _tickerService = tickerService;
        }

        public void Dispose()
        {
            _tickerRepository?.Dispose();
            _tickerService?.Dispose();
        }

        public async Task<Ticker> getTicker(TipoMoeda moeda)
        {
            return await _tickerService.getTicker(moeda);
        }
    }
}
