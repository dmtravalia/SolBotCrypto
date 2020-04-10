using AutoMapper;
using BotCrypto.ColetaInformacao.Application.ViewModels;
using BotCrypto.ColetaInformacao.Domain;

namespace BotCrypto.ColetaInformacao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Ticker, TickerViewModel>();
        }
    }
}
