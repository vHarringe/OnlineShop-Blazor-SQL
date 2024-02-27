
using blazorLabWebutveckling.Data;
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using blazorLabWebutveckling.Services.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;




namespace blazorLabWebutveckling.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public ApplicationDbContext _context;
        public IServiceScopeFactory ServiceScopeFactory { get; }

        public CartService(ICartRepository cartRepository, ApplicationDbContext context, IServiceScopeFactory serviceScopeFactory)
        {
            _cartRepository = cartRepository;
            _context = context;
            ServiceScopeFactory = serviceScopeFactory;
        }
        public event Action? OnCartUpdated;


        public async Task AddCartItem(Car car, string userId, int quantity)
        {
            var cart = await _cartRepository.GetCart(userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _cartRepository.AddCart(cart);
            }

            if (cart.Items == null)
            {
                cart.Items = new List<CartItem>(); 
            }

            var cartItem = cart.Items.FirstOrDefault(i => i.Car == car);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cart.Items.Add(new CartItem { Quantity = quantity, Car = car });
            }
            

            await _context.SaveChangesAsync();
            OnCartUpdated?.Invoke();

        }

        public Task<IEnumerable<CartItem>> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public async Task<Cart> GetCart(string userId)
        {
            var cart = await _cartRepository.GetCart(userId);
            return cart;
        }
        //public async Task<int> GetItemCount(string userId)
        //{
        //    return await _cartRepository.GetItemCount(userId);

        //}
        public async Task<int> GetItemCount(string userId, int? carId = null)
        {

            using (var scope = ServiceScopeFactory.CreateScope())
            {
                var scopedCartRepository = scope.ServiceProvider.GetRequiredService<ICartRepository>();
                if (carId.HasValue)
                {
                    var itemCount = await scopedCartRepository.GetItemCount(userId, carId);
                    return itemCount;
                }
                else
                {
                    return await scopedCartRepository.GetItemCount(userId); 

                }
            }
        }

        public Task RemoveCartItem()
        {
            throw new NotImplementedException();
        }
    }
}
