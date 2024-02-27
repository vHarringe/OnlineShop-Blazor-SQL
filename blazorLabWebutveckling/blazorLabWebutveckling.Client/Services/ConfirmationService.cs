using DTOs;
using System.Net.Http.Json;

namespace blazorLabWebutveckling.Client.Services
{
    public class ConfirmationService : IConfirmationService
    {
        private readonly HttpClient httpClient;

        public ConfirmationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<OrderDto> GetOrderConfirmation(int id)
        {
            try
            {
                
                var confirmation = await this.httpClient.GetFromJsonAsync<OrderDto>($"api/confirm/{id}");
                return confirmation ?? new OrderDto();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
