using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.Core.Data;

namespace BotCrypto.ColetaInformacao.Data.Repository
{
    public class TickerRepository : ITickerRepository
    {
        private readonly ColetaInformacaoContext _context;

        public TickerRepository(ColetaInformacaoContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
