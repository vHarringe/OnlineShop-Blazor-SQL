using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Services.ServiceInterfaces;

public interface IOrderService
{
    public Task AddOrder(Cart cart, string adress, string name, string email);
    public event Action OnCartUpdatedOrder;

}
