using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }

    public class OrderItemDto
    {
        public int ItemId { get; set; }
        public CarDto car { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CarDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionShort { get; set; }

    }
}
