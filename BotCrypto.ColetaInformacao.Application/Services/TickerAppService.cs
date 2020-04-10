using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.ColetaInformacao.Domain.Enum;

namespace BotCrypto.ColetaInformacao.Application.Services
{
    public class TickerAppService : ITickerAppService
    {
        private readonly ITickerRepository _tickerRepository;
        private readonly ITickerService _tickerService;
        public void Dispose()
        {
            _tickerRepository?.Dispose();
            _tickerService?.Dispose();
        }

        public Ticker getTicker(TipoMoeda moeda)
        {
            return _tickerService.getTicker(moeda);
        }
    }
}
