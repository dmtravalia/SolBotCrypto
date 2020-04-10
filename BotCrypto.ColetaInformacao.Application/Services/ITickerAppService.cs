using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.ColetaInformacao.Domain.Enum;
using System;

namespace BotCrypto.ColetaInformacao.Application.Services
{
    public interface ITickerAppService : IDisposable
    {
        Ticker getTicker(TipoMoeda moeda);
    }
}
