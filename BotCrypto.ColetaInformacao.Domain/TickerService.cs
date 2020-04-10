using BotCrypto.ColetaInformacao.Domain.Enum;
using BotCrypto.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace BotCrypto.ColetaInformacao.Domain
{
    public class TickerService : ITickerService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Ticker getTicker(TipoMoeda moeda)
        {
            Ticker ticker;
            var requisicaoWeb = WebRequest.CreateHttp("https://www.mercadobitcoin.net/api/" + moeda.ToString() + "/ticker/");
            requisicaoWeb.Method = "GET";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                var details = JObject.Parse(objResponse.ToString());
                string obj_ticker = details["ticker"].ToString();

                ticker = JsonConvert.DeserializeObject<Ticker>(obj_ticker);
                streamDados.Close();
                resposta.Close();
            }

            ticker.DateNormal = Util.UnixTimeStampToDateTime(ticker.date);

            return ticker;
        }
    }
}
