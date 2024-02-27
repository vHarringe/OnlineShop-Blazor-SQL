using DTOs;

namespace blazorLabWebutveckling.Client.Services
{
    public interface IConfirmationService
    {
        public Task<OrderDto> GetOrderConfirmation(int id);
    }
}
