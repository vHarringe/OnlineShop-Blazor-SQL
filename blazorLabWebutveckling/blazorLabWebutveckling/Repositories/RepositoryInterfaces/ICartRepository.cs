using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Repositories.RepositoryInterfaces
{
    public interface ICartRepository
    {
        public Task DecreaseQuantity(Car car, int quantity);
        public Task RemoveCart(Cart cart);
        public Task AddCart(Cart cart);
        public Task<Cart> GetCart(string userId);
        public Task<int> GetItemCount(string userId, int? carId = null);

    }
}
