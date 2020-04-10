using AutoMapper;
using BotCrypto.ColetaInformacao.Application.ViewModels;
using BotCrypto.ColetaInformacao.Domain;

namespace BotCrypto.ColetaInformacao.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Ticker, TickerViewModel>();
        }
    }
}
