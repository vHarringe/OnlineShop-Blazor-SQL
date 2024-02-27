using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Repositories.RepositoryInterfaces
{
    public interface IOrderRepository
    {
        public Task AddOrder(Order order);
        public Task<Order> GetOrder(int id);
    }
}
