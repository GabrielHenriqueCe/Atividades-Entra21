using Newtonsoft.Json;

namespace Aula_19.Servicos
{
    internal class CotacaoService
    {
        private static HttpClient _client = new HttpClient();

        public async Task<decimal> ObterCotacaoDolarAsync()
        {
            string url = "https://economia.awesomeapi.com.br/json/last/USD-BRL";
            string json = await _client.GetStringAsync(url);
            dynamic resultado = JsonConvert.DeserializeObject<dynamic>(json);
            return (decimal)resultado.USDBRL.bid;
        }
    }
}