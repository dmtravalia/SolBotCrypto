using BotCrypto.ColetaInformacao.Domain;
using BotCrypto.ColetaInformacao.Domain.Enum;
using System;
using System.Threading.Tasks;

namespace BotCrypto.ColetaInformacao.Application.Services
{
    public interface ITickerAppService : IDisposable
    {
        Task<Ticker> getTicker(TipoMoeda moeda);
    }
}
