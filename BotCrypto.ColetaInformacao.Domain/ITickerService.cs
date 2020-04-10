using BotCrypto.ColetaInformacao.Domain.Enum;
using System;
using System.Threading.Tasks;

namespace BotCrypto.ColetaInformacao.Domain
{
    public interface ITickerService : IDisposable
    {
        Task<Ticker> getTicker(TipoMoeda moeda);
    }
}
