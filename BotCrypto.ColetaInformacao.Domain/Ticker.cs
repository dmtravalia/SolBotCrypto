using BotCrypto.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BotCrypto.ColetaInformacao.Domain
{
    public class Ticker : Entity, IAggregateRoot
    {
        [Description("Data e hora da criação do registro.")]
        public DateTime dtCriacao { get; set; }


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
