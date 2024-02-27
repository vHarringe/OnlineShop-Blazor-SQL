using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using blazorLabWebutveckling.Services.ServiceInterfaces;
using DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace blazorLabWebutveckling.Services
{
    public class OrderService : IOrderService
    {
        private readonly ICartRepository cartRepository;

        public OrderService(IOrderRepository orderRepository, ICartRepository cs)
        {
            OrderRepository = orderRepository;
            cartRepository = cs;
        }
        public event Action OnCartUpdatedOrder;

        public IOrderRepository OrderRepository { get; }

        public async Task AddOrder(Cart cart, string adress, string name, string email)
        {
            Order order = new();

            order.Name = name;
            order.Address = adress;
            order.Email = email;
            order.OrderItems = new List<OrderItem>();
            foreach(var item in cart.Items)
            {

                order.OrderItems.Add(new OrderItem
                {
                    Car = item.Car,
                    CarId = item.CarId,
                    Quantity = item.Quantity,
                    Order = order,
                    OrderId = order.Id,
                    
                    
                });
            }


            await OrderRepository.AddOrder(order);
            foreach(var car in cart.Items)
            {
                await cartRepository.DecreaseQuantity(car.Car, car.Quantity);

            }
            await cartRepository.RemoveCart(cart);
            OnCartUpdatedOrder?.Invoke();

        }

        public async Task<OrderDto> GetOrder(int id)
        {
            var order = await OrderRepository.GetOrder(id);
            var orderDto = new OrderDto
                {
                Id = order.Id,
                Name = order.Name,
                Address = order.Address,
                Email = order.Email,
                Items = order.OrderItems.Select(item => new OrderItemDto
                {
                    ItemId = item.OrderItemId,
                    car = new CarDto
                    {
                        Id = item.Car.Id,
                        DescriptionShort = item.Car.DescriptionShort,
                        Name = item.Car.Name
                    },
                    Price = item.Car.PriceEUR,
                    Quantity = item.Quantity

                }).ToList(),

            };

            return orderDto;

        }


    }
}
