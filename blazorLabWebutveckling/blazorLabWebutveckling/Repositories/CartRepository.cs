
using blazorLabWebutveckling.Data;
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;


namespace blazorLabWebutveckling.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _data;

        public CartRepository(ApplicationDbContext data)
        {
            _data = data;
        }

        public async Task<Cart> GetCart(string userId)
        {
            var cart = await _data.Carts
                                   .Include(c => c.Items)
                                   .ThenInclude(i => i.Car)
                                   .FirstOrDefaultAsync(c => c.UserId == userId);
            return cart;
        }
        public async Task AddCart(Cart cart)
        {
            await _data.Carts.AddAsync(cart);
            await _data.SaveChangesAsync();
        }

        

        public async Task DecreaseQuantity(Car car, int quantity)
        {

           
            var carQtyUpdate = await _data.Cars.FirstOrDefaultAsync(c => c.Id == car.Id); 
            
            
            if(carQtyUpdate != null)
            {
                carQtyUpdate.Qty -= quantity;
            }
            

            await _data.SaveChangesAsync();


        }

        public async Task RemoveCart(Cart cart)
        {
            _data.Carts.Remove(cart);
            await _data.SaveChangesAsync();
        }

        public Task<int> GetItemCount(string userId)
        {
            return _data.Carts
                   .Where(c => c.UserId == userId)
                   .SelectMany(c => c.Items)
                   .SumAsync(i => i.Quantity);
        }
    }
}
