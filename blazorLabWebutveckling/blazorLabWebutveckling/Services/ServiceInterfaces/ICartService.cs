﻿using blazorLabWebutveckling.Entities;

namespace blazorLabWebutveckling.Services.ServiceInterfaces
{
    public interface ICartService
    {
        public Task AddCartItem(Car car, string userId, int quantity);
        
        public Task RemoveCartItem();
        public Task<IEnumerable<CartItem>> GetCartItems();

        public Task<Cart> GetCart(string userId);

        public Task<int> GetItemCount(string userId, int? carId = null);

        public event Action OnCartUpdated;


    }
}
