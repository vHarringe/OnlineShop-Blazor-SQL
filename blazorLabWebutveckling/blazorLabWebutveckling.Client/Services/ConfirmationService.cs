using DTOs;
using System.Net.Http.Json;

namespace blazorLabWebutveckling.Client.Services
{
    public class ConfirmationService
    {
        private readonly HttpClient httpClient;

        public ConfirmationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<OrderDto> GetOrderConfirmation(int id)
        {
            var confirmation = await this.httpClient.GetFromJsonAsync<OrderDto>("api/confirm");
            return confirmation ?? new OrderDto();

        }
    }
}
