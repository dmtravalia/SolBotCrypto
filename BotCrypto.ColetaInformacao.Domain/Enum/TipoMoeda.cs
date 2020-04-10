using System.ComponentModel;

namespace BotCrypto.ColetaInformacao.Domain.Enum
{
    public enum TipoMoeda
    {
        [Description("Bitcoin")]
        BTC,

        [Description("Litecoin")]
        LTC,

        [Description("BCash")]
        BCH,

        [Description("XRP (Ripple)")]
        XRP,

        [Description("Ethereum")]
        ETH
    };
}
