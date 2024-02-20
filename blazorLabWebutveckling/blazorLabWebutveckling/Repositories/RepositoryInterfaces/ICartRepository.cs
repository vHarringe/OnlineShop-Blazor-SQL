using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Repositories.RepositoryInterfaces
{
    public interface ICartRepository
    {
        public Task DecreaseQuantity(Car car, int quantity);
        public Task AddCart(Cart cart);
        public Task<Cart> GetCart(string userId);

    }
}
