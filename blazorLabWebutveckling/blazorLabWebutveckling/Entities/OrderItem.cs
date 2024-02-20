namespace blazorLabWebutveckling.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

    }
}
