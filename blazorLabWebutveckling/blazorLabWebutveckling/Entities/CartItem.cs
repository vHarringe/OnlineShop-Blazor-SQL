
namespace blazorLabWebutveckling.Entities
{
   
    public class CartItem
    {
        public int CartItemId { get; set; } 
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        
    }
   
}
