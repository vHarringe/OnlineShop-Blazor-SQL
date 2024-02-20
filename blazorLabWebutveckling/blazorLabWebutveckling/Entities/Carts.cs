using Microsoft.AspNetCore.Identity;

namespace blazorLabWebutveckling.Entities
{
    
        public class Cart
        {
            public int CartId { get; set; } 
            public string UserId { get; set; } 
            public List<CartItem> Items { get; set; } 
        }

    
}
