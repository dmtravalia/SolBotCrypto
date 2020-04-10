using BotCrypto.ColetaInformacao.Domain.Enum;
using System;

namespace BotCrypto.ColetaInformacao.Domain
{
    public interface ITickerService : IDisposable
    {
        Ticker getTicker(TipoMoeda moeda);
    }
}
