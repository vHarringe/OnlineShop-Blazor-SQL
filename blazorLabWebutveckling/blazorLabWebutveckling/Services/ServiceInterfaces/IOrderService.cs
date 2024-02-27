using blazorLabWebutveckling.Entities;
using DTOs;

namespace blazorLabWebutveckling.Services.ServiceInterfaces;

public interface IOrderService
{
    public Task AddOrder(Cart cart, string adress, string name, string email);
    public Task<OrderDto> GetOrder(int id);
    public event Action OnCartUpdatedOrder;

}
