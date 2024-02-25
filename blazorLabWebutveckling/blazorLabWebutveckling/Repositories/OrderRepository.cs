using blazorLabWebutveckling.Data;
using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;

namespace blazorLabWebutveckling.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public ApplicationDbContext Context { get; }
        public OrderRepository(ApplicationDbContext context)
        {
            Context = context;
        }


        public async Task AddOrder(Order order)
        {
            await Context.Orders.AddAsync(order);
            await Context.SaveChangesAsync();
        }
    }
}
