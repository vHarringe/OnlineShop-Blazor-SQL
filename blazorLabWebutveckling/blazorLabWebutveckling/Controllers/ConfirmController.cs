using blazorLabWebutveckling.Entities;
using blazorLabWebutveckling.Repositories.RepositoryInterfaces;
using blazorLabWebutveckling.Services.ServiceInterfaces;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blazorLabWebutveckling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmController : ControllerBase
    {
        private readonly IOrderService orderService;

        public ConfirmController(IOrderService orderService) 
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public async Task<OrderDto> GetOrder(int id) 
        {
            var orderDto = await orderService.GetOrder(id);

            return orderDto;
        }
    }
}
