using BotCrypto.ColetaInformacao.Domain.Enum;
using System;
using System.ComponentModel;

namespace BotCrypto.ColetaInformacao.Application.ViewModels
{
    public class TickerViewModel
    {
        [Description("Tipo da Moeda.")]
        public TipoMoeda TipoMoeda { get; set; }

        [Description("Maior preço de oferta de compra das últimas 24 horas.")]
        public double buy { get; set; }

        [Description("Menor preço de oferta de venda das últimas 24 horas.")]
        public double sell { get; set; }

        [Description("Maior preço unitário de negociação das últimas 24 horas.")]
        public double high { get; set; }

        [Description("Menor preço unitário de negociação das últimas 24 horas.")]
        public double low { get; set; }

        [Description("Quantidade negociada nas últimas 24 horas.")]
        public double vol { get; set; }

        [Description("Preço unitário da última negociação.")]
        public double last { get; set; }

        [Description("Data e hora da informação em Era Unix")]
        public int date { get; set; }

        [Description("Data e hora da negociação normal.")]
        public DateTime DateNormal { get; set; }
    }
}
