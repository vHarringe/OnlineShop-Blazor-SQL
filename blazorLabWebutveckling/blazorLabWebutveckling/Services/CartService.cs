
using blazorLabWebutveckling.Data;
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using blazorLabWebutveckling.Services.ServiceInterfaces;




namespace blazorLabWebutveckling.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public ApplicationDbContext _context;

        public CartService(ICartRepository cartRepository, ApplicationDbContext context)
        {
            _cartRepository = cartRepository;
            _context = context;
        }


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
            await _cartRepository.DecreaseQuantity(car, quantity);

            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<CartItem>> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public Task RemoveCartItem()
        {
            throw new NotImplementedException();
        }

        public async Task<Cart> GetCart(string userId)
        {
            var cart = await _cartRepository.GetCart(userId);
            return cart;
        }
    }
}
