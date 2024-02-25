using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace blazorLabWebutveckling.Services
{
    public class ExchangeAPI
    {
        private readonly HttpClient _httpClient;
        

        public ExchangeAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> GetExchangeRate(string toCurrency)
        {
            var apiUrl = $"https://api.api-ninjas.com/v1/exchangerate?pair=EUR_{toCurrency}";
            string apiKey = "U/tWzm0+xhEQq+ePAlHXPw==QbjG5CtE2rEwvQ59";


            var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
            request.Headers.Add("X-Api-Key", apiKey);

            try
            {
                var response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();

                var exchangeRateResult = await response.Content.ReadFromJsonAsync<ExchangeRateResult>();

                if (exchangeRateResult != null)
                {
                    return exchangeRateResult.Rate;
                }

               
                throw new InvalidOperationException("Received null response from the exchange rate API.");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request failed: {e.Message}");
                throw;
            }
        }

        private class ExchangeRateResult
        {
            [JsonPropertyName("exchange_rate")]
            public decimal Rate { get; set; }
        }

    }
}
